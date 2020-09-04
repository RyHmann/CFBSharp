/* 
 * College Football Data API
 *
 * This is an API for accessing all sorts of college football data.  It currently has a wide array of data ranging from play by play to player statistics to game scores and more.
 *
 * OpenAPI spec version: 2.2.11
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
    /// TeamSPRatingSpecialTeams
    /// </summary>
    [DataContract]
    public partial class TeamSPRatingSpecialTeams :  IEquatable<TeamSPRatingSpecialTeams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamSPRatingSpecialTeams" /> class.
        /// </summary>
        /// <param name="rating">rating.</param>
        public TeamSPRatingSpecialTeams(decimal? rating = default(decimal?))
        {
            this.Rating = rating;
        }
        
        /// <summary>
        /// Gets or Sets Rating
        /// </summary>
        [DataMember(Name="rating", EmitDefaultValue=false)]
        public decimal? Rating { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeamSPRatingSpecialTeams {\n");
            sb.Append("  Rating: ").Append(Rating).Append("\n");
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
            return this.Equals(input as TeamSPRatingSpecialTeams);
        }

        /// <summary>
        /// Returns true if TeamSPRatingSpecialTeams instances are equal
        /// </summary>
        /// <param name="input">Instance of TeamSPRatingSpecialTeams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeamSPRatingSpecialTeams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Rating == input.Rating ||
                    (this.Rating != null &&
                    this.Rating.Equals(input.Rating))
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
                if (this.Rating != null)
                    hashCode = hashCode * 59 + this.Rating.GetHashCode();
                return hashCode;
            }
        }
    }

}
