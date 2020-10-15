using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CardGuessManager.Data;

using Newtonsoft.Json;

namespace CardGuessManager
{
    public partial class Main : Form
    {
        public class ToolLockout : IDisposable
        {
            private readonly Main window;

            public ToolLockout(Main window)
            {
                this.window = window;
                DisableTools();
            }

            public void Dispose()
            {
                EnableTools();
            }

            private void DisableTools()
            {
                window.guessControls.Enabled = false;
                window.guessEditor.Enabled = false;
            }

            private void EnableTools()
            {
                window.guessControls.Enabled = true;
                if (!(window.currentGame is null))
                    window.guessEditor.Enabled = true;
            }
        }

        public HttpClient client = new HttpClient();
        public UriBuilder uriBuilder = new UriBuilder();

        public Dictionary<int, string> Api = new Dictionary<int, string>() { { 1, "/api/v1" } };

        public string Auth { get; set; }

        #region Card Data
        public int? CurrentGameId { get; set; } = null;
        public List<CardGuess> CurrentGameData = new List<CardGuess>();
        public List<CardGuess> Queue = new List<CardGuess>();
        public CardGuess? Editing = null;
        public bool LiveEdit = false;
        #endregion

        public static bool IsDebug
        {
            get
            {
#if DEBUG
                return true;
#else
                return false;
#endif
            }
        }
        #region Setup
        public Main()
        {
            if(IsDebug)
            {
                uriBuilder.Host = "localhost";
                uriBuilder.Port = 8050;
                uriBuilder.Scheme = "http";
            }
            else
            {
                uriBuilder.Host = "andrewbounds.com";
                uriBuilder.Scheme = "https";
            }

            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            #region Admin Setup
            // disable everything but the login buttons.
            guessControls.Enabled = false;
            guessEditor.Enabled = false;
            #endregion
        }
        #endregion

        #region Utility
        private void ItemSelector_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var obj = (ComboBox)sender;
                if (obj.Items.Contains(obj.Text))
                    obj.SelectedItem = obj.Text;
            }
            catch { }
        }

        private Task UpdateCurrentGameBox()
        {
            // Then populate the server list box
            currentGame.Items.Clear();
            currentGame.Items.AddRange(items: CurrentGameData.ToArray());
            return Task.CompletedTask;
        }

        private Task UpdateQueueBox()
        {
            // Update the queue box
            cardsQueue.Items.Clear();
            cardsQueue.Items.AddRange(items: Queue.ToArray());
            return Task.CompletedTask;
        }

        public Task ClearEditFields()
        {
            cardSelector.SelectedItem = null;
            dateInput.Text = null;
            timeInput.Text = null;
            userIdInput.Text = null;
            teamSelector.SelectedItem = null;

            return Task.CompletedTask;
        }

        public Task ClearQueue()
        {
            Queue.Clear();
            cardsQueue.Items.Clear();

            return Task.CompletedTask;
        }

        /// <summary>
        /// Verifies all inputs fields are filled, and opens messages boxes if they are not.
        /// </summary>
        /// <returns>True if all input fields are not blank.</returns>
        public Task<bool> VerifyAllInputsAreFilled()
        {
            if(teamSelector.SelectedItem is null)
            {
                MessageBox.Show("No Team Selected", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Task.FromResult(false);
            }

            if(!userIdInput.MaskCompleted)
            {
                MessageBox.Show("No User Id", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Task.FromResult(false);
            }

            if(cardSelector.SelectedItem is null)
            {
                MessageBox.Show("No Card Selected", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Task.FromResult(false);
            }

            if (!dateInput.MaskCompleted)
            {
                MessageBox.Show("No Date", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Task.FromResult(false);
            }

            if (!timeInput.MaskCompleted)
            {
                MessageBox.Show("No Time", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Task.FromResult(false);
            }

            return Task.FromResult(true);
        }

        public async Task GetCurrentGame()
        {
            var old = connectionLabel.Text;
            connectionLabel.Text = "GET-ing Current Game";

            var b = new UriBuilder(uriBuilder.Uri)
            {
                Path = Api[1] + "/game/current"
            };

            var request = new HttpRequestMessage()
            {
                RequestUri = b.Uri,
                Method = HttpMethod.Get
            };
            try
            {
                request.Headers.Add("Authorization", Auth);

                var res = await client.SendAsync(request);

                if (res.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var json = await res.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<CurrentGame>(json);

                    // Now that we have the data, lets add it to the server panel.

                    if (data.GameId >= 0)
                    {
                        CurrentGameData = data.Guesses;
                        CurrentGameId = data.GameId;
                        // Lets enabled editing
                        guessEditor.Enabled = true;
                        // And update the game label
                        gameNumLbl.Text = CurrentGameId?.ToString() ?? "Error";

                        await UpdateCurrentGameBox();
                    }
                    else
                    {
                        MessageBox.Show("Failed to get any data from the API", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                toolTip.ToolTipTitle = "Request Failed";
                toolTip.Show(ex.Message, getCurrentGame);
            }
            finally
            {
                connectionLabel.Text = old;
            }
        }

        public async Task SaveGuess(CardGuess? guess = null)
        {
            // Make sure all inputs are filled
            if (!await VerifyAllInputsAreFilled()) return;
            if (CurrentGameId is null) return;

            if (winnerCheckBox.Checked)
            {
                // Make sure this is the winning card.
                var res = MessageBox.Show("Are you sure this is the Winning Guess?\n" +
                    "Marking this guess as the winner will close this game, sync queue data to the server, and make the data un-editibale from the API.\n\n" +
                    "Press No to store guess in Queue as a noral guess.\n" +
                    "Press Cancel to remove this guess.\n" +
                    "Press Yes to continue.\n\n" +
                    "Guess:\n" +
                    $"{cardSelector.Text} - {userIdInput.Text} [{dateInput.Text} - {timeInput.Text}]"
                    , "Confirm Winner", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (res == DialogResult.No)
                    winnerCheckBox.Checked = false;
                else if (res == DialogResult.No)
                    return;
            }

            // Build the CardGuess object
            if (guess is null)
            {
                guess = new CardGuess();
                Queue.Add(guess);
            }

            // Save values to the guess object.
            guess.Team = teamSelector.Text;
            guess.Card = cardSelector.Text;
            guess.Date = dateInput.Text;
            guess.Time = timeInput.Text;
            guess.UserId = userIdInput.Text;
            guess.GameId = CurrentGameId ?? -1;

            // And update the queue box.
            await UpdateQueueBox();

            // This time we are sure this is correct, so lets execute the code.
            if (winnerCheckBox.Checked)
            {
                using var lockout = new ToolLockout(this);
                // POST updates
                await PostQueueToLive();
                // POST winner
                await PostWinnerToLive(guess);
                // Then clear the queue data
                var q = ClearQueue();
                // GET the new current game
                await GetCurrentGame();

                await q;
            }

            await ClearEditFields();
        }

        public async Task PostQueueToLive()
        {
            var old = connectionLabel.Text;
            connectionLabel.Text = "POST-ing Queue to Live";

            var json = JsonConvert.SerializeObject(Queue);

            var b = new UriBuilder(uriBuilder.Uri)
            {
                Path = Api[1] + "/game/guess"
            };

            var request = new HttpRequestMessage()
            {
                RequestUri = b.Uri,
                Method = HttpMethod.Post
            };

            request.Content = new StringContent(json, Encoding.UTF8, "application/json");

            request.Headers.Add("Authorization", Auth);
            try
            {
                var res = await client.SendAsync(request);

                if (res.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    // Add the queue to the game
                    CurrentGameData.AddRange(Queue);
                    var box = UpdateCurrentGameBox();

                    // Clear the queue
                    var q = ClearQueue();

                    await box; await q;
                }
                else
                {
                    toolTip.ToolTipTitle = "POST Failed";
                    toolTip.Show("Failed to POST card updates to API. Check JSON data and API logs.", postToServer);
                }
            }
            catch (Exception ex)
            {
                toolTip.ToolTipTitle = "POST Errored";
                toolTip.Show("Failed to POST card updates to API. Check JSON data and API logs.\n" + ex.Message, postToServer);
            }
            finally
            {
                connectionLabel.Text = old;
            }
        }

        public async Task PostWinnerToLive(CardGuess guess)
        {
            var old = connectionLabel.Text;
            connectionLabel.Text = "POST-ing Winner";

            var jsonDict = new Dictionary<string, object>()
            {
                { "user_id", guess.UserId },
                { "card", guess.Card },
                { "date", guess.Date },
                { "game_id", guess.GameId }
            };

            var json = JsonConvert.SerializeObject(jsonDict);

            var b = new UriBuilder(uriBuilder.Uri)
            {
                Path = Api[1] + "/game/victory"
            };

            var request = new HttpRequestMessage()
            {
                RequestUri = b.Uri,
                Method = HttpMethod.Post
            };

            request.Content = new StringContent(json, Encoding.UTF8, "application/json");

            request.Headers.Add("Authorization", Auth);

            try
            {
                var res = await client.SendAsync(request);

                if(res.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var q = ClearQueue();

                    // Get the new game.
                    await GetCurrentGame();

                    await q;
                }
                else
                {
                    toolTip.ToolTipTitle = "POST Errored";
                    toolTip.Show("Failed to POST game winner to API. Check JSON data and API logs.", postWinner);
                }
            }
            catch (Exception ex)
            {
                toolTip.ToolTipTitle = "POST Errored";
                toolTip.Show("Failed to POST game winner to API. Check JSON data and API logs.\n" + ex.Message, postWinner);
            }
            finally
            {
                connectionLabel.Text = old;
            }
        }
        #endregion

        #region Tooltips
        private void MaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            var input = (MaskedTextBox)sender;

            if (input.MaskFull)
            {
                toolTip.ToolTipTitle = "Input Rejected - Too Much Data";
                toolTip.Show("You cannot enter any more data into the date field. Delete some characters in order to insert more data.", input, 0, -20, 5000);
            }
            else if (e.Position == userIdInput.Mask.Length)
            {
                toolTip.ToolTipTitle = "Input Rejected - End of Field";
                toolTip.Show("You cannot add extra characters to the end of this date field.", input, 0, -20, 5000);
            }
            else
            {
                toolTip.ToolTipTitle = "Input Rejected";
                toolTip.Show("You can only add numeric characters (0-9) into this date field.", input, 0, -20, 5000);
            }
        }

        private void userIdInput_KeyDown(object sender, KeyEventArgs e)
        {
            toolTip.Hide(userIdInput);
        }

        private void dateInput_KeyDown(object sender, KeyEventArgs e)
        {
            toolTip.Hide(dateInput);
        }

        private void timeInput_KeyDown(object sender, KeyEventArgs e)
        {
            toolTip.Hide(timeInput);
        }
        #endregion

        #region Button Presses

        private async void CheckAuth_Click(object sender, EventArgs e)
        {
            var b = new UriBuilder(uriBuilder.Uri);
            b.Path = Api[1] + "/testauth";

            var request = new HttpRequestMessage()
            {
                RequestUri = b.Uri,
                Method = HttpMethod.Post
            };

            var encoded = Convert.ToBase64String(Encoding.UTF8.GetBytes(usernameInput.Text + ":" + passwordInput.Text));
            var temp_auth = "Basic " + encoded;
            request.Headers.Add("Authorization", temp_auth);
            try
            {
                var res = await client.SendAsync(request);

                if (res.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    // Only enable the controls. GET current game needs to be
                    // triggered to get the editor page open.
                    guessControls.Enabled = true;
                    Auth = temp_auth;
                    connectionLabel.Text = "Authenticated";
                }
                else
                {
                    MessageBox.Show("Failed to verify Auth", "Auth Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to verify Auth\n{ex.Message}", "Auth Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void GetCurrentGame_Click(object sender, EventArgs e)
        {
            using var lockout = new ToolLockout(this);
            await GetCurrentGame();
        }

        private async void NewGuess_Click(object sender, EventArgs e)
        {
            await SaveGuess();
        }

        private async void ClearQueue_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Are you sure you want to clear the Queue? This acction is irreversible.", "Clear Queue",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if(res == DialogResult.OK)
            {
                await ClearQueue();
            }
        }

        private async void DeleteQueued_Click(object sender, EventArgs e)
        {
            if (cardsQueue.SelectedItem is null)
            {
                toolTip.ToolTipTitle = "No Queue Item Selected";
                toolTip.Show("You must select an item from the Queue to delete it.", deleteQueued, 0, -20, 2500);
                return;
            }

            var guess = (CardGuess)cardsQueue.SelectedItem;
            Queue.Remove(guess);
            await UpdateQueueBox();
        }

        private async void StartEdit_Click(object sender, EventArgs e)
        {
            if (cardsQueue.SelectedItem is null)
            {
                toolTip.ToolTipTitle = "No Queue Item Selected";
                toolTip.Show("You must select an item from the Queue to edit it.", startEdit, 0, -20, 2500);
                return;
            }

            var guess = (CardGuess)cardsQueue.SelectedItem;
            newGuess.Enabled = false; // disable the submit new guess button., use the save button to save editing data.
            Editing = guess; // save the editing file so we know what is getting edited.
            LiveEdit = false; // This is a Queue edit, not a live edit. This changes the save procedure.

            await ClearEditFields(); // lets get a clean slate.

            teamSelector.SelectedItem = Editing.Team;
            cardSelector.SelectedItem = Editing.Card;

            userIdInput.Text = Editing.UserId;
            dateInput.Text = Editing.Date;

            if (Editing.Time.Length == 4) // Make sure the remote data matches the Mask
                Editing.Time = "0" + Editing.Time;

            timeInput.Text = Editing.Time;
        }

        private async void SaveEdit_Click(object sender, EventArgs e)
        {
            if (Editing is null)
            {
                toolTip.ToolTipTitle = "Nothing Being Edited";
                toolTip.Show("You must edit an item before you can save it.", saveEdit, 0, -20, 2500);
                return;
            }

            if(LiveEdit)
            {
                // Send a POST request to /api/v1/games/edit



                await ClearEditFields();
            }
            else
            {
                await SaveGuess(Editing);
            }

            Editing = null;
            LiveEdit = false;
            newGuess.Enabled = true; // Re-enable the regular add button.
        }

        private async void ClearEditor_Click(object sender, EventArgs e)
        {
            Editing = null;
            LiveEdit = false;
            await ClearEditFields();
        }

        private async void PostToServer_Click(object sender, EventArgs e)
        {
            if (Queue.Count <= 0)
            {
                toolTip.ToolTipTitle = "Nothing to POST";
                toolTip.Show("Add items to the Queue before POSting to the API.", postToServer, 0, -20, 2500);
                return; // nothing to POST, dont run the method.
            }

            using var lockout = new ToolLockout(this);
            await PostQueueToLive();
        }

        private async void PostWinner_Click(object sender, EventArgs e)
        {
            if(currentGame.SelectedItem is null)
            {
                toolTip.ToolTipTitle = "No Guess Selected on Live";
                toolTip.Show("Select a guess from the Live panel to POST it as the winning guess.", postWinner, 0, -20, 2500);
                return; // nothing to POST, dont run the method.
            }

            var res = MessageBox.Show("Are you sure this guess is the winning guess? Submiting this will prevent editing of this game through the API.",
                "POST Winner", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(res == DialogResult.Yes)
            {
                using var lockout = new ToolLockout(this);                

                await PostWinnerToLive((CardGuess)currentGame.SelectedItem);
            }
        }
        #endregion

    }
}
