namespace CardGuessManager
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pageController = new System.Windows.Forms.TabControl();
            this.homeTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.adminTab = new System.Windows.Forms.TabPage();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.checkAuth = new System.Windows.Forms.Button();
            this.guessEditor = new System.Windows.Forms.Panel();
            this.timeInput = new System.Windows.Forms.MaskedTextBox();
            this.dateInput = new System.Windows.Forms.MaskedTextBox();
            this.userIdInput = new System.Windows.Forms.MaskedTextBox();
            this.winnerCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gameNumLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.newGuess = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.teamSelector = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cardLabel = new System.Windows.Forms.Label();
            this.cardSelector = new System.Windows.Forms.ComboBox();
            this.guessControls = new System.Windows.Forms.Panel();
            this.cancelEdit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.liveControlsLabel = new System.Windows.Forms.Label();
            this.postDelete = new System.Windows.Forms.Button();
            this.postWinner = new System.Windows.Forms.Button();
            this.editServerGuess = new System.Windows.Forms.Button();
            this.getCurrentGame = new System.Windows.Forms.Button();
            this.clearQueue = new System.Windows.Forms.Button();
            this.postToServer = new System.Windows.Forms.Button();
            this.saveEdit = new System.Windows.Forms.Button();
            this.deleteQueued = new System.Windows.Forms.Button();
            this.currentGame = new System.Windows.Forms.ListBox();
            this.cardsQueue = new System.Windows.Forms.ListBox();
            this.startEdit = new System.Windows.Forms.Button();
            this.adminStatusStrip = new System.Windows.Forms.StatusStrip();
            this.connectionLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pageController.SuspendLayout();
            this.homeTab.SuspendLayout();
            this.adminTab.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.guessEditor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.guessControls.SuspendLayout();
            this.adminStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pageController
            // 
            this.pageController.Controls.Add(this.homeTab);
            this.pageController.Controls.Add(this.adminTab);
            this.pageController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageController.Location = new System.Drawing.Point(0, 0);
            this.pageController.Name = "pageController";
            this.pageController.SelectedIndex = 0;
            this.pageController.Size = new System.Drawing.Size(1256, 450);
            this.pageController.TabIndex = 0;
            // 
            // homeTab
            // 
            this.homeTab.Controls.Add(this.label1);
            this.homeTab.Location = new System.Drawing.Point(4, 24);
            this.homeTab.Name = "homeTab";
            this.homeTab.Padding = new System.Windows.Forms.Padding(3);
            this.homeTab.Size = new System.Drawing.Size(1248, 422);
            this.homeTab.TabIndex = 0;
            this.homeTab.Text = "Home";
            this.homeTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Everything here is TODO! Visit https://andrewbounds.com/ for more information";
            // 
            // adminTab
            // 
            this.adminTab.Controls.Add(this.loginPanel);
            this.adminTab.Controls.Add(this.guessEditor);
            this.adminTab.Controls.Add(this.guessControls);
            this.adminTab.Controls.Add(this.adminStatusStrip);
            this.adminTab.Location = new System.Drawing.Point(4, 24);
            this.adminTab.Name = "adminTab";
            this.adminTab.Padding = new System.Windows.Forms.Padding(3);
            this.adminTab.Size = new System.Drawing.Size(1248, 422);
            this.adminTab.TabIndex = 1;
            this.adminTab.Text = "Admin";
            this.adminTab.UseVisualStyleBackColor = true;
            // 
            // loginPanel
            // 
            this.loginPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginPanel.Controls.Add(this.label11);
            this.loginPanel.Controls.Add(this.label10);
            this.loginPanel.Controls.Add(this.passwordInput);
            this.loginPanel.Controls.Add(this.usernameInput);
            this.loginPanel.Controls.Add(this.checkAuth);
            this.loginPanel.Location = new System.Drawing.Point(8, 9);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(428, 80);
            this.loginPanel.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(0, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 23);
            this.label11.TabIndex = 2;
            this.label11.Text = "Password:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(0, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 23);
            this.label10.TabIndex = 2;
            this.label10.Text = "Username:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(74, 44);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(177, 23);
            this.passwordInput.TabIndex = 1;
            this.passwordInput.UseSystemPasswordChar = true;
            // 
            // usernameInput
            // 
            this.usernameInput.Location = new System.Drawing.Point(74, 15);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(177, 23);
            this.usernameInput.TabIndex = 0;
            // 
            // checkAuth
            // 
            this.checkAuth.Location = new System.Drawing.Point(269, 46);
            this.checkAuth.Name = "checkAuth";
            this.checkAuth.Size = new System.Drawing.Size(93, 23);
            this.checkAuth.TabIndex = 3;
            this.checkAuth.Text = "Check Auth";
            this.checkAuth.UseVisualStyleBackColor = true;
            this.checkAuth.Click += new System.EventHandler(this.CheckAuth_Click);
            // 
            // guessEditor
            // 
            this.guessEditor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guessEditor.Controls.Add(this.timeInput);
            this.guessEditor.Controls.Add(this.dateInput);
            this.guessEditor.Controls.Add(this.userIdInput);
            this.guessEditor.Controls.Add(this.winnerCheckBox);
            this.guessEditor.Controls.Add(this.groupBox1);
            this.guessEditor.Controls.Add(this.newGuess);
            this.guessEditor.Controls.Add(this.label8);
            this.guessEditor.Controls.Add(this.label7);
            this.guessEditor.Controls.Add(this.teamSelector);
            this.guessEditor.Controls.Add(this.label6);
            this.guessEditor.Controls.Add(this.label5);
            this.guessEditor.Controls.Add(this.cardLabel);
            this.guessEditor.Controls.Add(this.cardSelector);
            this.guessEditor.Location = new System.Drawing.Point(8, 95);
            this.guessEditor.Name = "guessEditor";
            this.guessEditor.Size = new System.Drawing.Size(428, 186);
            this.guessEditor.TabIndex = 5;
            // 
            // timeInput
            // 
            this.timeInput.Location = new System.Drawing.Point(64, 124);
            this.timeInput.Mask = "00:00";
            this.timeInput.Name = "timeInput";
            this.timeInput.Size = new System.Drawing.Size(127, 23);
            this.timeInput.TabIndex = 4;
            this.timeInput.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MaskedTextBox_MaskInputRejected);
            this.timeInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.timeInput_KeyDown);
            // 
            // dateInput
            // 
            this.dateInput.Location = new System.Drawing.Point(64, 95);
            this.dateInput.Mask = "00/00/0000";
            this.dateInput.Name = "dateInput";
            this.dateInput.Size = new System.Drawing.Size(127, 23);
            this.dateInput.TabIndex = 3;
            this.dateInput.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MaskedTextBox_MaskInputRejected);
            this.dateInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateInput_KeyDown);
            // 
            // userIdInput
            // 
            this.userIdInput.Location = new System.Drawing.Point(64, 36);
            this.userIdInput.Mask = "000000000000000000";
            this.userIdInput.Name = "userIdInput";
            this.userIdInput.Size = new System.Drawing.Size(127, 23);
            this.userIdInput.TabIndex = 1;
            this.userIdInput.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MaskedTextBox_MaskInputRejected);
            this.userIdInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userIdInput_KeyDown);
            // 
            // winnerCheckBox
            // 
            this.winnerCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.winnerCheckBox.Location = new System.Drawing.Point(9, 156);
            this.winnerCheckBox.Name = "winnerCheckBox";
            this.winnerCheckBox.Size = new System.Drawing.Size(68, 27);
            this.winnerCheckBox.TabIndex = 0;
            this.winnerCheckBox.Text = "Winner";
            this.winnerCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gameNumLbl);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(197, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 137);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game Information";
            // 
            // gameNumLbl
            // 
            this.gameNumLbl.AutoSize = true;
            this.gameNumLbl.Location = new System.Drawing.Point(44, 36);
            this.gameNumLbl.Name = "gameNumLbl";
            this.gameNumLbl.Size = new System.Drawing.Size(141, 15);
            this.gameNumLbl.TabIndex = 1;
            this.gameNumLbl.Text = "GET game to update stats";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(6, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "Current Game Number:";
            // 
            // newGuess
            // 
            this.newGuess.Location = new System.Drawing.Point(83, 156);
            this.newGuess.Name = "newGuess";
            this.newGuess.Size = new System.Drawing.Size(326, 23);
            this.newGuess.TabIndex = 5;
            this.newGuess.Text = "Submit New Guess";
            this.newGuess.UseVisualStyleBackColor = true;
            this.newGuess.Click += new System.EventHandler(this.NewGuess_Click);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(9, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 23);
            this.label8.TabIndex = 1;
            this.label8.Text = "Time:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(9, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "Date:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // teamSelector
            // 
            this.teamSelector.FormattingEnabled = true;
            this.teamSelector.Items.AddRange(new object[] {
            "P",
            "D",
            "R",
            "C",
            "U",
            "W",
            "E",
            "N",
            "n/a"});
            this.teamSelector.Location = new System.Drawing.Point(64, 8);
            this.teamSelector.Name = "teamSelector";
            this.teamSelector.Size = new System.Drawing.Size(127, 23);
            this.teamSelector.TabIndex = 0;
            this.teamSelector.TextChanged += new System.EventHandler(this.ItemSelector_TextChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(9, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Team:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(9, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "User:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cardLabel
            // 
            this.cardLabel.Location = new System.Drawing.Point(9, 66);
            this.cardLabel.Name = "cardLabel";
            this.cardLabel.Size = new System.Drawing.Size(49, 23);
            this.cardLabel.TabIndex = 1;
            this.cardLabel.Text = "Card:";
            this.cardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cardSelector
            // 
            this.cardSelector.FormattingEnabled = true;
            this.cardSelector.Items.AddRange(new object[] {
            "AC",
            "2C",
            "3C",
            "4C",
            "5C",
            "6C",
            "7C",
            "8C",
            "9C",
            "10C",
            "JC",
            "QC",
            "KC",
            "AD",
            "2D",
            "3D",
            "4D",
            "5D",
            "6D",
            "7D",
            "8D",
            "9D",
            "10D",
            "JD",
            "QD",
            "KD",
            "AH",
            "2H",
            "3H",
            "4H",
            "5H",
            "6H",
            "7H",
            "8H",
            "9H",
            "10H",
            "JH",
            "QH",
            "KH",
            "AS",
            "2S",
            "3S",
            "4S",
            "5S",
            "6S",
            "7S",
            "8S",
            "9S",
            "10S",
            "JS",
            "QS",
            "KS"});
            this.cardSelector.Location = new System.Drawing.Point(64, 66);
            this.cardSelector.Name = "cardSelector";
            this.cardSelector.Size = new System.Drawing.Size(127, 23);
            this.cardSelector.TabIndex = 2;
            this.cardSelector.TextChanged += new System.EventHandler(this.ItemSelector_TextChanged);
            // 
            // guessControls
            // 
            this.guessControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guessControls.Controls.Add(this.cancelEdit);
            this.guessControls.Controls.Add(this.label4);
            this.guessControls.Controls.Add(this.label3);
            this.guessControls.Controls.Add(this.label2);
            this.guessControls.Controls.Add(this.liveControlsLabel);
            this.guessControls.Controls.Add(this.postDelete);
            this.guessControls.Controls.Add(this.postWinner);
            this.guessControls.Controls.Add(this.editServerGuess);
            this.guessControls.Controls.Add(this.getCurrentGame);
            this.guessControls.Controls.Add(this.clearQueue);
            this.guessControls.Controls.Add(this.postToServer);
            this.guessControls.Controls.Add(this.saveEdit);
            this.guessControls.Controls.Add(this.deleteQueued);
            this.guessControls.Controls.Add(this.currentGame);
            this.guessControls.Controls.Add(this.cardsQueue);
            this.guessControls.Controls.Add(this.startEdit);
            this.guessControls.Location = new System.Drawing.Point(442, 0);
            this.guessControls.Name = "guessControls";
            this.guessControls.Size = new System.Drawing.Size(803, 394);
            this.guessControls.TabIndex = 4;
            // 
            // cancelEdit
            // 
            this.cancelEdit.Location = new System.Drawing.Point(19, 271);
            this.cancelEdit.Name = "cancelEdit";
            this.cancelEdit.Size = new System.Drawing.Size(82, 23);
            this.cancelEdit.TabIndex = 3;
            this.cancelEdit.Text = "Clear Editor";
            this.cancelEdit.UseVisualStyleBackColor = true;
            this.cancelEdit.Click += new System.EventHandler(this.ClearEditor_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(488, -1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(310, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Live";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(107, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(310, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Queue";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(19, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Queue Controls";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // liveControlsLabel
            // 
            this.liveControlsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.liveControlsLabel.Location = new System.Drawing.Point(424, 10);
            this.liveControlsLabel.Name = "liveControlsLabel";
            this.liveControlsLabel.Size = new System.Drawing.Size(58, 31);
            this.liveControlsLabel.TabIndex = 4;
            this.liveControlsLabel.Text = "Live Controls";
            this.liveControlsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // postDelete
            // 
            this.postDelete.Location = new System.Drawing.Point(423, 96);
            this.postDelete.Name = "postDelete";
            this.postDelete.Size = new System.Drawing.Size(59, 59);
            this.postDelete.TabIndex = 3;
            this.postDelete.Text = "POST Delete Guess";
            this.postDelete.UseVisualStyleBackColor = true;
            // 
            // postWinner
            // 
            this.postWinner.Location = new System.Drawing.Point(423, 44);
            this.postWinner.Name = "postWinner";
            this.postWinner.Size = new System.Drawing.Size(59, 46);
            this.postWinner.TabIndex = 3;
            this.postWinner.Text = "POST Winner";
            this.postWinner.UseVisualStyleBackColor = true;
            this.postWinner.Click += new System.EventHandler(this.PostWinner_Click);
            // 
            // editServerGuess
            // 
            this.editServerGuess.Location = new System.Drawing.Point(423, 207);
            this.editServerGuess.Name = "editServerGuess";
            this.editServerGuess.Size = new System.Drawing.Size(59, 46);
            this.editServerGuess.TabIndex = 3;
            this.editServerGuess.Text = "◀◀  Edit";
            this.editServerGuess.UseVisualStyleBackColor = true;
            // 
            // getCurrentGame
            // 
            this.getCurrentGame.Location = new System.Drawing.Point(423, 328);
            this.getCurrentGame.Name = "getCurrentGame";
            this.getCurrentGame.Size = new System.Drawing.Size(59, 61);
            this.getCurrentGame.TabIndex = 3;
            this.getCurrentGame.Text = "GET Current Game";
            this.getCurrentGame.UseVisualStyleBackColor = true;
            this.getCurrentGame.Click += new System.EventHandler(this.GetCurrentGame_Click);
            // 
            // clearQueue
            // 
            this.clearQueue.Location = new System.Drawing.Point(19, 44);
            this.clearQueue.Name = "clearQueue";
            this.clearQueue.Size = new System.Drawing.Size(82, 23);
            this.clearQueue.TabIndex = 3;
            this.clearQueue.Text = "Clear Queue";
            this.clearQueue.UseVisualStyleBackColor = true;
            this.clearQueue.Click += new System.EventHandler(this.ClearQueue_Click);
            // 
            // postToServer
            // 
            this.postToServer.Location = new System.Drawing.Point(423, 260);
            this.postToServer.Name = "postToServer";
            this.postToServer.Size = new System.Drawing.Size(59, 62);
            this.postToServer.TabIndex = 3;
            this.postToServer.Text = "POST Updates ▶";
            this.postToServer.UseVisualStyleBackColor = true;
            this.postToServer.Click += new System.EventHandler(this.PostToServer_Click);
            // 
            // saveEdit
            // 
            this.saveEdit.Location = new System.Drawing.Point(19, 242);
            this.saveEdit.Name = "saveEdit";
            this.saveEdit.Size = new System.Drawing.Size(82, 23);
            this.saveEdit.TabIndex = 3;
            this.saveEdit.Text = "Save ✓";
            this.saveEdit.UseVisualStyleBackColor = true;
            this.saveEdit.Click += new System.EventHandler(this.SaveEdit_Click);
            // 
            // deleteQueued
            // 
            this.deleteQueued.Location = new System.Drawing.Point(19, 73);
            this.deleteQueued.Name = "deleteQueued";
            this.deleteQueued.Size = new System.Drawing.Size(82, 23);
            this.deleteQueued.TabIndex = 3;
            this.deleteQueued.Text = "Delete ❌";
            this.deleteQueued.UseVisualStyleBackColor = true;
            this.deleteQueued.Click += new System.EventHandler(this.DeleteQueued_Click);
            // 
            // currentGame
            // 
            this.currentGame.FormattingEnabled = true;
            this.currentGame.ItemHeight = 15;
            this.currentGame.Location = new System.Drawing.Point(488, 23);
            this.currentGame.Name = "currentGame";
            this.currentGame.Size = new System.Drawing.Size(310, 364);
            this.currentGame.TabIndex = 1;
            // 
            // cardsQueue
            // 
            this.cardsQueue.FormattingEnabled = true;
            this.cardsQueue.ItemHeight = 15;
            this.cardsQueue.Location = new System.Drawing.Point(107, 24);
            this.cardsQueue.Name = "cardsQueue";
            this.cardsQueue.Size = new System.Drawing.Size(310, 364);
            this.cardsQueue.TabIndex = 2;
            // 
            // startEdit
            // 
            this.startEdit.Location = new System.Drawing.Point(19, 213);
            this.startEdit.Name = "startEdit";
            this.startEdit.Size = new System.Drawing.Size(82, 23);
            this.startEdit.TabIndex = 3;
            this.startEdit.Text = "◀ Edit";
            this.startEdit.UseVisualStyleBackColor = true;
            this.startEdit.Click += new System.EventHandler(this.StartEdit_Click);
            // 
            // adminStatusStrip
            // 
            this.adminStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionLabel});
            this.adminStatusStrip.Location = new System.Drawing.Point(3, 397);
            this.adminStatusStrip.Name = "adminStatusStrip";
            this.adminStatusStrip.Size = new System.Drawing.Size(1242, 22);
            this.adminStatusStrip.TabIndex = 0;
            this.adminStatusStrip.Text = "Admin Status";
            // 
            // connectionLabel
            // 
            this.connectionLabel.Name = "connectionLabel";
            this.connectionLabel.Size = new System.Drawing.Size(61, 17);
            this.connectionLabel.Text = "Unverified";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 450);
            this.Controls.Add(this.pageController);
            this.Name = "Main";
            this.Text = "Card Came Companion";
            this.Load += new System.EventHandler(this.Main_Load);
            this.pageController.ResumeLayout(false);
            this.homeTab.ResumeLayout(false);
            this.homeTab.PerformLayout();
            this.adminTab.ResumeLayout(false);
            this.adminTab.PerformLayout();
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.guessEditor.ResumeLayout(false);
            this.guessEditor.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.guessControls.ResumeLayout(false);
            this.adminStatusStrip.ResumeLayout(false);
            this.adminStatusStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl pageController;
        private System.Windows.Forms.TabPage homeTab;
        private System.Windows.Forms.TabPage adminTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip adminStatusStrip;
        private System.Windows.Forms.ListBox cardQueu;
        private System.Windows.Forms.ListBox currentGame;
        private System.Windows.Forms.Button saveEdit;
        private System.Windows.Forms.Button clearQueue;
        private System.Windows.Forms.Button startEdit;
        private System.Windows.Forms.Button deleteQueued;
        private System.Windows.Forms.Button postToServer;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button editServer;
        private System.Windows.Forms.ListBox cardsQueue;
        private System.Windows.Forms.Button editServerGuess;
        private System.Windows.Forms.Button getCurrentGame;
        private System.Windows.Forms.Button postWinner;
        private System.Windows.Forms.Button postDelete;
        private System.Windows.Forms.Label liveControlsLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.ComboBox cardSelector;
        private System.Windows.Forms.Label cardLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox teamSelector;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button newGuess;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label gameNumLbl;
        private System.Windows.Forms.Button checkAuth;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStripStatusLabel connectionLabel;
        private System.Windows.Forms.CheckBox winnerCheckBox;
        private System.Windows.Forms.MaskedTextBox userIdInput;
        private System.Windows.Forms.MaskedTextBox timeInput;
        private System.Windows.Forms.MaskedTextBox dateInput;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button cancelEdit;
        public System.Windows.Forms.Panel guessEditor;
        public System.Windows.Forms.Panel guessControls;
    }
}

