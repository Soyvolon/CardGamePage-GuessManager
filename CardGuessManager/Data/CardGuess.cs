using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;

using Newtonsoft.Json;

namespace CardGuessManager.Data
{
    public class CardGuess
    {
        [JsonProperty("game")]
        public int GameId { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("card")]
        public string Card { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("team")]
        public string Team { get; set; }

        public CardGuess(int gameId = -1, string userId = "", string card = "", string date = "", string time = "", string team = "")
        {
            this.GameId = gameId;
            this.UserId = userId;
            this.Card = card;
            this.Date = date;
            this.Time = time;
            this.Team = team;
        }

        public override string ToString()
        {
            return $"{Card} - {Team} - {UserId} - {Date} - {Time}";
        }
    }
}
