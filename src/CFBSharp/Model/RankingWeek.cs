/* 
 * College Football Data API
 *
 * This is an API for accessing all sorts of college football data.  It currently has a wide array of data ranging from play by play to player statistics to game scores and more.
 *
 * OpenAPI spec version: 1.24.5
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
    /// RankingWeek
    /// </summary>
    [DataContract]
    public partial class RankingWeek :  IEquatable<RankingWeek>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RankingWeek" /> class.
        /// </summary>
        /// <param name="season">season.</param>
        /// <param name="seasonType">seasonType.</param>
        /// <param name="week">week.</param>
        /// <param name="polls">polls.</param>
        public RankingWeek(int? season = default(int?), string seasonType = default(string), int? week = default(int?), List<RankingWeekPolls> polls = default(List<RankingWeekPolls>))
        {
            this.Season = season;
            this.SeasonType = seasonType;
            this.Week = week;
            this.Polls = polls;
        }
        
        /// <summary>
        /// Gets or Sets Season
        /// </summary>
        [DataMember(Name="season", EmitDefaultValue=false)]
        public int? Season { get; set; }

        /// <summary>
        /// Gets or Sets SeasonType
        /// </summary>
        [DataMember(Name="seasonType", EmitDefaultValue=false)]
        public string SeasonType { get; set; }

        /// <summary>
        /// Gets or Sets Week
        /// </summary>
        [DataMember(Name="week", EmitDefaultValue=false)]
        public int? Week { get; set; }

        /// <summary>
        /// Gets or Sets Polls
        /// </summary>
        [DataMember(Name="polls", EmitDefaultValue=false)]
        public List<RankingWeekPolls> Polls { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RankingWeek {\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  SeasonType: ").Append(SeasonType).Append("\n");
            sb.Append("  Week: ").Append(Week).Append("\n");
            sb.Append("  Polls: ").Append(Polls).Append("\n");
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
            return this.Equals(input as RankingWeek);
        }

        /// <summary>
        /// Returns true if RankingWeek instances are equal
        /// </summary>
        /// <param name="input">Instance of RankingWeek to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RankingWeek input)
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
                    this.SeasonType == input.SeasonType ||
                    (this.SeasonType != null &&
                    this.SeasonType.Equals(input.SeasonType))
                ) && 
                (
                    this.Week == input.Week ||
                    (this.Week != null &&
                    this.Week.Equals(input.Week))
                ) && 
                (
                    this.Polls == input.Polls ||
                    this.Polls != null &&
                    this.Polls.SequenceEqual(input.Polls)
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
                if (this.SeasonType != null)
                    hashCode = hashCode * 59 + this.SeasonType.GetHashCode();
                if (this.Week != null)
                    hashCode = hashCode * 59 + this.Week.GetHashCode();
                if (this.Polls != null)
                    hashCode = hashCode * 59 + this.Polls.GetHashCode();
                return hashCode;
            }
        }
    }

}