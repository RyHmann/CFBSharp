/* 
 * College Football Data API
 *
 * This is an API for accessing all sorts of college football data.  Please note that API keys should be supplied with \"Bearer \" prepended (e.g. \"Bearer your_key\"). API keys can be acquired from the CollegeFootballData.com website.
 *
 * OpenAPI spec version: 4.3.2
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
    /// AdvancedGameStat
    /// </summary>
    [DataContract]
    public partial class AdvancedGameStat :  IEquatable<AdvancedGameStat>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdvancedGameStat" /> class.
        /// </summary>
        /// <param name="gameId">gameId.</param>
        /// <param name="season">season.</param>
        /// <param name="week">week.</param>
        /// <param name="team">team.</param>
        /// <param name="opponent">opponent.</param>
        /// <param name="offense">offense.</param>
        /// <param name="defense">defense.</param>
        public AdvancedGameStat(int? gameId = default(int?), int? season = default(int?), int? week = default(int?), string team = default(string), string opponent = default(string), Object offense = default(Object), Object defense = default(Object))
        {
            this.GameId = gameId;
            this.Season = season;
            this.Week = week;
            this.Team = team;
            this.Opponent = opponent;
            this.Offense = offense;
            this.Defense = defense;
        }
        
        /// <summary>
        /// Gets or Sets GameId
        /// </summary>
        [DataMember(Name="gameId", EmitDefaultValue=false)]
        public int? GameId { get; set; }

        /// <summary>
        /// Gets or Sets Season
        /// </summary>
        [DataMember(Name="season", EmitDefaultValue=false)]
        public int? Season { get; set; }

        /// <summary>
        /// Gets or Sets Week
        /// </summary>
        [DataMember(Name="week", EmitDefaultValue=false)]
        public int? Week { get; set; }

        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name="team", EmitDefaultValue=false)]
        public string Team { get; set; }

        /// <summary>
        /// Gets or Sets Opponent
        /// </summary>
        [DataMember(Name="opponent", EmitDefaultValue=false)]
        public string Opponent { get; set; }

        /// <summary>
        /// Gets or Sets Offense
        /// </summary>
        [DataMember(Name="offense", EmitDefaultValue=false)]
        public Object Offense { get; set; }

        /// <summary>
        /// Gets or Sets Defense
        /// </summary>
        [DataMember(Name="defense", EmitDefaultValue=false)]
        public Object Defense { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdvancedGameStat {\n");
            sb.Append("  GameId: ").Append(GameId).Append("\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  Week: ").Append(Week).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Opponent: ").Append(Opponent).Append("\n");
            sb.Append("  Offense: ").Append(Offense).Append("\n");
            sb.Append("  Defense: ").Append(Defense).Append("\n");
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
            return this.Equals(input as AdvancedGameStat);
        }

        /// <summary>
        /// Returns true if AdvancedGameStat instances are equal
        /// </summary>
        /// <param name="input">Instance of AdvancedGameStat to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdvancedGameStat input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GameId == input.GameId ||
                    (this.GameId != null &&
                    this.GameId.Equals(input.GameId))
                ) && 
                (
                    this.Season == input.Season ||
                    (this.Season != null &&
                    this.Season.Equals(input.Season))
                ) && 
                (
                    this.Week == input.Week ||
                    (this.Week != null &&
                    this.Week.Equals(input.Week))
                ) && 
                (
                    this.Team == input.Team ||
                    (this.Team != null &&
                    this.Team.Equals(input.Team))
                ) && 
                (
                    this.Opponent == input.Opponent ||
                    (this.Opponent != null &&
                    this.Opponent.Equals(input.Opponent))
                ) && 
                (
                    this.Offense == input.Offense ||
                    (this.Offense != null &&
                    this.Offense.Equals(input.Offense))
                ) && 
                (
                    this.Defense == input.Defense ||
                    (this.Defense != null &&
                    this.Defense.Equals(input.Defense))
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
                if (this.GameId != null)
                    hashCode = hashCode * 59 + this.GameId.GetHashCode();
                if (this.Season != null)
                    hashCode = hashCode * 59 + this.Season.GetHashCode();
                if (this.Week != null)
                    hashCode = hashCode * 59 + this.Week.GetHashCode();
                if (this.Team != null)
                    hashCode = hashCode * 59 + this.Team.GetHashCode();
                if (this.Opponent != null)
                    hashCode = hashCode * 59 + this.Opponent.GetHashCode();
                if (this.Offense != null)
                    hashCode = hashCode * 59 + this.Offense.GetHashCode();
                if (this.Defense != null)
                    hashCode = hashCode * 59 + this.Defense.GetHashCode();
                return hashCode;
            }
        }
    }

}
