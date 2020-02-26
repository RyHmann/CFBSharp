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
    /// TeamSPRatingDefenseHavoc
    /// </summary>
    [DataContract]
    public partial class TeamSPRatingDefenseHavoc :  IEquatable<TeamSPRatingDefenseHavoc>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamSPRatingDefenseHavoc" /> class.
        /// </summary>
        /// <param name="total">total.</param>
        /// <param name="frontSeven">frontSeven.</param>
        /// <param name="db">db.</param>
        public TeamSPRatingDefenseHavoc(decimal? total = default(decimal?), decimal? frontSeven = default(decimal?), decimal? db = default(decimal?))
        {
            this.Total = total;
            this.FrontSeven = frontSeven;
            this.Db = db;
        }
        
        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public decimal? Total { get; set; }

        /// <summary>
        /// Gets or Sets FrontSeven
        /// </summary>
        [DataMember(Name="frontSeven", EmitDefaultValue=false)]
        public decimal? FrontSeven { get; set; }

        /// <summary>
        /// Gets or Sets Db
        /// </summary>
        [DataMember(Name="db", EmitDefaultValue=false)]
        public decimal? Db { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeamSPRatingDefenseHavoc {\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  FrontSeven: ").Append(FrontSeven).Append("\n");
            sb.Append("  Db: ").Append(Db).Append("\n");
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
            return this.Equals(input as TeamSPRatingDefenseHavoc);
        }

        /// <summary>
        /// Returns true if TeamSPRatingDefenseHavoc instances are equal
        /// </summary>
        /// <param name="input">Instance of TeamSPRatingDefenseHavoc to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeamSPRatingDefenseHavoc input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.FrontSeven == input.FrontSeven ||
                    (this.FrontSeven != null &&
                    this.FrontSeven.Equals(input.FrontSeven))
                ) && 
                (
                    this.Db == input.Db ||
                    (this.Db != null &&
                    this.Db.Equals(input.Db))
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
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.FrontSeven != null)
                    hashCode = hashCode * 59 + this.FrontSeven.GetHashCode();
                if (this.Db != null)
                    hashCode = hashCode * 59 + this.Db.GetHashCode();
                return hashCode;
            }
        }
    }

}