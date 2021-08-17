/* 
 * College Football Data API
 *
 * This is an API for accessing all sorts of college football data.  Please note that API keys should be supplied with \"Bearer \" prepended (e.g. \"Bearer your_key\"). API keys can be acquired from the CollegeFootballData.com website.
 *
 * OpenAPI spec version: 4.1.5
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
    /// TeamSeasonStat
    /// </summary>
    [DataContract]
    public partial class TeamSeasonStat :  IEquatable<TeamSeasonStat>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamSeasonStat" /> class.
        /// </summary>
        /// <param name="season">season.</param>
        /// <param name="team">team.</param>
        /// <param name="conference">conference.</param>
        /// <param name="statName">statName.</param>
        /// <param name="statValue">statValue.</param>
        public TeamSeasonStat(int? season = default(int?), string team = default(string), string conference = default(string), string statName = default(string), int? statValue = default(int?))
        {
            this.Season = season;
            this.Team = team;
            this.Conference = conference;
            this.StatName = statName;
            this.StatValue = statValue;
        }
        
        /// <summary>
        /// Gets or Sets Season
        /// </summary>
        [DataMember(Name="season", EmitDefaultValue=false)]
        public int? Season { get; set; }

        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name="team", EmitDefaultValue=false)]
        public string Team { get; set; }

        /// <summary>
        /// Gets or Sets Conference
        /// </summary>
        [DataMember(Name="conference", EmitDefaultValue=false)]
        public string Conference { get; set; }

        /// <summary>
        /// Gets or Sets StatName
        /// </summary>
        [DataMember(Name="statName", EmitDefaultValue=false)]
        public string StatName { get; set; }

        /// <summary>
        /// Gets or Sets StatValue
        /// </summary>
        [DataMember(Name="statValue", EmitDefaultValue=false)]
        public int? StatValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeamSeasonStat {\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Conference: ").Append(Conference).Append("\n");
            sb.Append("  StatName: ").Append(StatName).Append("\n");
            sb.Append("  StatValue: ").Append(StatValue).Append("\n");
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
            return this.Equals(input as TeamSeasonStat);
        }

        /// <summary>
        /// Returns true if TeamSeasonStat instances are equal
        /// </summary>
        /// <param name="input">Instance of TeamSeasonStat to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeamSeasonStat input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Season == input.Season ||
                    (this.Season != null &&
                    this.Season.Equals(input.Season))
                ) && 
                (
                    this.Team == input.Team ||
                    (this.Team != null &&
                    this.Team.Equals(input.Team))
                ) && 
                (
                    this.Conference == input.Conference ||
                    (this.Conference != null &&
                    this.Conference.Equals(input.Conference))
                ) && 
                (
                    this.StatName == input.StatName ||
                    (this.StatName != null &&
                    this.StatName.Equals(input.StatName))
                ) && 
                (
                    this.StatValue == input.StatValue ||
                    (this.StatValue != null &&
                    this.StatValue.Equals(input.StatValue))
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
                if (this.Season != null)
                    hashCode = hashCode * 59 + this.Season.GetHashCode();
                if (this.Team != null)
                    hashCode = hashCode * 59 + this.Team.GetHashCode();
                if (this.Conference != null)
                    hashCode = hashCode * 59 + this.Conference.GetHashCode();
                if (this.StatName != null)
                    hashCode = hashCode * 59 + this.StatName.GetHashCode();
                if (this.StatValue != null)
                    hashCode = hashCode * 59 + this.StatValue.GetHashCode();
                return hashCode;
            }
        }
    }

}
