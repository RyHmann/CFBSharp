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
    /// RankingWeekRanks
    /// </summary>
    [DataContract]
    public partial class RankingWeekRanks :  IEquatable<RankingWeekRanks>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RankingWeekRanks" /> class.
        /// </summary>
        /// <param name="rank">rank.</param>
        /// <param name="school">school.</param>
        /// <param name="conference">conference.</param>
        /// <param name="firstPlaceVotes">firstPlaceVotes.</param>
        /// <param name="points">points.</param>
        public RankingWeekRanks(int? rank = default(int?), string school = default(string), string conference = default(string), int? firstPlaceVotes = default(int?), int? points = default(int?))
        {
            this.Rank = rank;
            this.School = school;
            this.Conference = conference;
            this.FirstPlaceVotes = firstPlaceVotes;
            this.Points = points;
        }
        
        /// <summary>
        /// Gets or Sets Rank
        /// </summary>
        [DataMember(Name="rank", EmitDefaultValue=false)]
        public int? Rank { get; set; }

        /// <summary>
        /// Gets or Sets School
        /// </summary>
        [DataMember(Name="school", EmitDefaultValue=false)]
        public string School { get; set; }

        /// <summary>
        /// Gets or Sets Conference
        /// </summary>
        [DataMember(Name="conference", EmitDefaultValue=false)]
        public string Conference { get; set; }

        /// <summary>
        /// Gets or Sets FirstPlaceVotes
        /// </summary>
        [DataMember(Name="firstPlaceVotes", EmitDefaultValue=false)]
        public int? FirstPlaceVotes { get; set; }

        /// <summary>
        /// Gets or Sets Points
        /// </summary>
        [DataMember(Name="points", EmitDefaultValue=false)]
        public int? Points { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RankingWeekRanks {\n");
            sb.Append("  Rank: ").Append(Rank).Append("\n");
            sb.Append("  School: ").Append(School).Append("\n");
            sb.Append("  Conference: ").Append(Conference).Append("\n");
            sb.Append("  FirstPlaceVotes: ").Append(FirstPlaceVotes).Append("\n");
            sb.Append("  Points: ").Append(Points).Append("\n");
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
            return this.Equals(input as RankingWeekRanks);
        }

        /// <summary>
        /// Returns true if RankingWeekRanks instances are equal
        /// </summary>
        /// <param name="input">Instance of RankingWeekRanks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RankingWeekRanks input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Rank == input.Rank ||
                    (this.Rank != null &&
                    this.Rank.Equals(input.Rank))
                ) && 
                (
                    this.School == input.School ||
                    (this.School != null &&
                    this.School.Equals(input.School))
                ) && 
                (
                    this.Conference == input.Conference ||
                    (this.Conference != null &&
                    this.Conference.Equals(input.Conference))
                ) && 
                (
                    this.FirstPlaceVotes == input.FirstPlaceVotes ||
                    (this.FirstPlaceVotes != null &&
                    this.FirstPlaceVotes.Equals(input.FirstPlaceVotes))
                ) && 
                (
                    this.Points == input.Points ||
                    (this.Points != null &&
                    this.Points.Equals(input.Points))
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
                if (this.Rank != null)
                    hashCode = hashCode * 59 + this.Rank.GetHashCode();
                if (this.School != null)
                    hashCode = hashCode * 59 + this.School.GetHashCode();
                if (this.Conference != null)
                    hashCode = hashCode * 59 + this.Conference.GetHashCode();
                if (this.FirstPlaceVotes != null)
                    hashCode = hashCode * 59 + this.FirstPlaceVotes.GetHashCode();
                if (this.Points != null)
                    hashCode = hashCode * 59 + this.Points.GetHashCode();
                return hashCode;
            }
        }
    }

}