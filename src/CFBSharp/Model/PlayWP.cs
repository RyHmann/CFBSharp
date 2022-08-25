/* 
 * College Football Data API
 *
 * This is an API for accessing all sorts of college football data.  Please note that API keys should be supplied with \"Bearer \" prepended (e.g. \"Bearer your_key\"). API keys can be acquired from the CollegeFootballData.com website.
 *
 * OpenAPI spec version: 4.4.2
 * Contact: admin@collegefootballdata.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = CFBSharp.Client.SwaggerDateConverter;

namespace CFBSharp.Model
{
    /// <summary>
    /// PlayWP
    /// </summary>
    [DataContract]
    public partial class PlayWP :  IEquatable<PlayWP>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayWP" /> class.
        /// </summary>
        /// <param name="gamesId">gamesId.</param>
        /// <param name="playId">playId.</param>
        /// <param name="playText">playText.</param>
        /// <param name="homeId">homeId.</param>
        /// <param name="home">home.</param>
        /// <param name="awayId">awayId.</param>
        /// <param name="away">away.</param>
        /// <param name="spread">spread.</param>
        /// <param name="homeBall">homeBall.</param>
        /// <param name="homeScore">homeScore.</param>
        /// <param name="awayScore">awayScore.</param>
        /// <param name="timeRemaining">timeRemaining.</param>
        /// <param name="yardLine">yardLine.</param>
        /// <param name="down">down.</param>
        /// <param name="distance">distance.</param>
        /// <param name="homeWinProb">homeWinProb.</param>
        /// <param name="playNumber">playNumber.</param>
        public PlayWP(int? gamesId = default(int?), int? playId = default(int?), string playText = default(string), int? homeId = default(int?), string home = default(string), int? awayId = default(int?), string away = default(string), decimal? spread = default(decimal?), bool? homeBall = default(bool?), int? homeScore = default(int?), int? awayScore = default(int?), int? timeRemaining = default(int?), int? yardLine = default(int?), int? down = default(int?), int? distance = default(int?), decimal? homeWinProb = default(decimal?), int? playNumber = default(int?))
        {
            this.GamesId = gamesId;
            this.PlayId = playId;
            this.PlayText = playText;
            this.HomeId = homeId;
            this.Home = home;
            this.AwayId = awayId;
            this.Away = away;
            this.Spread = spread;
            this.HomeBall = homeBall;
            this.HomeScore = homeScore;
            this.AwayScore = awayScore;
            this.TimeRemaining = timeRemaining;
            this.YardLine = yardLine;
            this.Down = down;
            this.Distance = distance;
            this.HomeWinProb = homeWinProb;
            this.PlayNumber = playNumber;
        }
        
        /// <summary>
        /// Gets or Sets GamesId
        /// </summary>
        [DataMember(Name="gamesId", EmitDefaultValue=false)]
        public int? GamesId { get; set; }

        /// <summary>
        /// Gets or Sets PlayId
        /// </summary>
        [DataMember(Name="playId", EmitDefaultValue=false)]
        public int? PlayId { get; set; }

        /// <summary>
        /// Gets or Sets PlayText
        /// </summary>
        [DataMember(Name="playText", EmitDefaultValue=false)]
        public string PlayText { get; set; }

        /// <summary>
        /// Gets or Sets HomeId
        /// </summary>
        [DataMember(Name="homeId", EmitDefaultValue=false)]
        public int? HomeId { get; set; }

        /// <summary>
        /// Gets or Sets Home
        /// </summary>
        [DataMember(Name="home", EmitDefaultValue=false)]
        public string Home { get; set; }

        /// <summary>
        /// Gets or Sets AwayId
        /// </summary>
        [DataMember(Name="awayId", EmitDefaultValue=false)]
        public int? AwayId { get; set; }

        /// <summary>
        /// Gets or Sets Away
        /// </summary>
        [DataMember(Name="away", EmitDefaultValue=false)]
        public string Away { get; set; }

        /// <summary>
        /// Gets or Sets Spread
        /// </summary>
        [DataMember(Name="spread", EmitDefaultValue=false)]
        public decimal? Spread { get; set; }

        /// <summary>
        /// Gets or Sets HomeBall
        /// </summary>
        [DataMember(Name="homeBall", EmitDefaultValue=false)]
        public bool? HomeBall { get; set; }

        /// <summary>
        /// Gets or Sets HomeScore
        /// </summary>
        [DataMember(Name="homeScore", EmitDefaultValue=false)]
        public int? HomeScore { get; set; }

        /// <summary>
        /// Gets or Sets AwayScore
        /// </summary>
        [DataMember(Name="awayScore", EmitDefaultValue=false)]
        public int? AwayScore { get; set; }

        /// <summary>
        /// Gets or Sets TimeRemaining
        /// </summary>
        [DataMember(Name="timeRemaining", EmitDefaultValue=false)]
        public int? TimeRemaining { get; set; }

        /// <summary>
        /// Gets or Sets YardLine
        /// </summary>
        [DataMember(Name="yardLine", EmitDefaultValue=false)]
        public int? YardLine { get; set; }

        /// <summary>
        /// Gets or Sets Down
        /// </summary>
        [DataMember(Name="down", EmitDefaultValue=false)]
        public int? Down { get; set; }

        /// <summary>
        /// Gets or Sets Distance
        /// </summary>
        [DataMember(Name="distance", EmitDefaultValue=false)]
        public int? Distance { get; set; }

        /// <summary>
        /// Gets or Sets HomeWinProb
        /// </summary>
        [DataMember(Name="homeWinProb", EmitDefaultValue=false)]
        public decimal? HomeWinProb { get; set; }

        /// <summary>
        /// Gets or Sets PlayNumber
        /// </summary>
        [DataMember(Name="playNumber", EmitDefaultValue=false)]
        public int? PlayNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlayWP {\n");
            sb.Append("  GamesId: ").Append(GamesId).Append("\n");
            sb.Append("  PlayId: ").Append(PlayId).Append("\n");
            sb.Append("  PlayText: ").Append(PlayText).Append("\n");
            sb.Append("  HomeId: ").Append(HomeId).Append("\n");
            sb.Append("  Home: ").Append(Home).Append("\n");
            sb.Append("  AwayId: ").Append(AwayId).Append("\n");
            sb.Append("  Away: ").Append(Away).Append("\n");
            sb.Append("  Spread: ").Append(Spread).Append("\n");
            sb.Append("  HomeBall: ").Append(HomeBall).Append("\n");
            sb.Append("  HomeScore: ").Append(HomeScore).Append("\n");
            sb.Append("  AwayScore: ").Append(AwayScore).Append("\n");
            sb.Append("  TimeRemaining: ").Append(TimeRemaining).Append("\n");
            sb.Append("  YardLine: ").Append(YardLine).Append("\n");
            sb.Append("  Down: ").Append(Down).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  HomeWinProb: ").Append(HomeWinProb).Append("\n");
            sb.Append("  PlayNumber: ").Append(PlayNumber).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PlayWP);
        }

        /// <summary>
        /// Returns true if PlayWP instances are equal
        /// </summary>
        /// <param name="input">Instance of PlayWP to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlayWP input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GamesId == input.GamesId ||
                    (this.GamesId != null &&
                    this.GamesId.Equals(input.GamesId))
                ) && 
                (
                    this.PlayId == input.PlayId ||
                    (this.PlayId != null &&
                    this.PlayId.Equals(input.PlayId))
                ) && 
                (
                    this.PlayText == input.PlayText ||
                    (this.PlayText != null &&
                    this.PlayText.Equals(input.PlayText))
                ) && 
                (
                    this.HomeId == input.HomeId ||
                    (this.HomeId != null &&
                    this.HomeId.Equals(input.HomeId))
                ) && 
                (
                    this.Home == input.Home ||
                    (this.Home != null &&
                    this.Home.Equals(input.Home))
                ) && 
                (
                    this.AwayId == input.AwayId ||
                    (this.AwayId != null &&
                    this.AwayId.Equals(input.AwayId))
                ) && 
                (
                    this.Away == input.Away ||
                    (this.Away != null &&
                    this.Away.Equals(input.Away))
                ) && 
                (
                    this.Spread == input.Spread ||
                    (this.Spread != null &&
                    this.Spread.Equals(input.Spread))
                ) && 
                (
                    this.HomeBall == input.HomeBall ||
                    (this.HomeBall != null &&
                    this.HomeBall.Equals(input.HomeBall))
                ) && 
                (
                    this.HomeScore == input.HomeScore ||
                    (this.HomeScore != null &&
                    this.HomeScore.Equals(input.HomeScore))
                ) && 
                (
                    this.AwayScore == input.AwayScore ||
                    (this.AwayScore != null &&
                    this.AwayScore.Equals(input.AwayScore))
                ) && 
                (
                    this.TimeRemaining == input.TimeRemaining ||
                    (this.TimeRemaining != null &&
                    this.TimeRemaining.Equals(input.TimeRemaining))
                ) && 
                (
                    this.YardLine == input.YardLine ||
                    (this.YardLine != null &&
                    this.YardLine.Equals(input.YardLine))
                ) && 
                (
                    this.Down == input.Down ||
                    (this.Down != null &&
                    this.Down.Equals(input.Down))
                ) && 
                (
                    this.Distance == input.Distance ||
                    (this.Distance != null &&
                    this.Distance.Equals(input.Distance))
                ) && 
                (
                    this.HomeWinProb == input.HomeWinProb ||
                    (this.HomeWinProb != null &&
                    this.HomeWinProb.Equals(input.HomeWinProb))
                ) && 
                (
                    this.PlayNumber == input.PlayNumber ||
                    (this.PlayNumber != null &&
                    this.PlayNumber.Equals(input.PlayNumber))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.GamesId != null)
                    hashCode = hashCode * 59 + this.GamesId.GetHashCode();
                if (this.PlayId != null)
                    hashCode = hashCode * 59 + this.PlayId.GetHashCode();
                if (this.PlayText != null)
                    hashCode = hashCode * 59 + this.PlayText.GetHashCode();
                if (this.HomeId != null)
                    hashCode = hashCode * 59 + this.HomeId.GetHashCode();
                if (this.Home != null)
                    hashCode = hashCode * 59 + this.Home.GetHashCode();
                if (this.AwayId != null)
                    hashCode = hashCode * 59 + this.AwayId.GetHashCode();
                if (this.Away != null)
                    hashCode = hashCode * 59 + this.Away.GetHashCode();
                if (this.Spread != null)
                    hashCode = hashCode * 59 + this.Spread.GetHashCode();
                if (this.HomeBall != null)
                    hashCode = hashCode * 59 + this.HomeBall.GetHashCode();
                if (this.HomeScore != null)
                    hashCode = hashCode * 59 + this.HomeScore.GetHashCode();
                if (this.AwayScore != null)
                    hashCode = hashCode * 59 + this.AwayScore.GetHashCode();
                if (this.TimeRemaining != null)
                    hashCode = hashCode * 59 + this.TimeRemaining.GetHashCode();
                if (this.YardLine != null)
                    hashCode = hashCode * 59 + this.YardLine.GetHashCode();
                if (this.Down != null)
                    hashCode = hashCode * 59 + this.Down.GetHashCode();
                if (this.Distance != null)
                    hashCode = hashCode * 59 + this.Distance.GetHashCode();
                if (this.HomeWinProb != null)
                    hashCode = hashCode * 59 + this.HomeWinProb.GetHashCode();
                if (this.PlayNumber != null)
                    hashCode = hashCode * 59 + this.PlayNumber.GetHashCode();
                return hashCode;
            }
        }
    }

}
