using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace CardGuessManager.Data
{
    public struct CurrentGame
    {
        [JsonProperty("game_id")]
        public int GameId { get; set; }
        [JsonProperty("guesses")]
        public List<CardGuess> Guesses { get; set; }
    }
}
