/* 
 * College Football Data API
 *
 * This is an API for accessing all sorts of college football data.  Please note that API keys should be supplied with \"Bearer \" prepended (e.g. \"Bearer your_key\"). API keys can be acquired from the CollegeFootballData.com website.
 *
 * OpenAPI spec version: 4.4.11
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
    /// ConferenceSPRatingOffense
    /// </summary>
    [DataContract]
    public partial class ConferenceSPRatingOffense :  IEquatable<ConferenceSPRatingOffense>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConferenceSPRatingOffense" /> class.
        /// </summary>
        /// <param name="rating">rating.</param>
        /// <param name="success">success.</param>
        /// <param name="explosiveness">explosiveness.</param>
        /// <param name="rushing">rushing.</param>
        /// <param name="passing">passing.</param>
        /// <param name="standardDowns">standardDowns.</param>
        /// <param name="passingDowns">passingDowns.</param>
        /// <param name="runRate">runRate.</param>
        /// <param name="pace">pace.</param>
        public ConferenceSPRatingOffense(decimal? rating = default(decimal?), decimal? success = default(decimal?), decimal? explosiveness = default(decimal?), decimal? rushing = default(decimal?), decimal? passing = default(decimal?), decimal? standardDowns = default(decimal?), decimal? passingDowns = default(decimal?), decimal? runRate = default(decimal?), decimal? pace = default(decimal?))
        {
            this.Rating = rating;
            this.Success = success;
            this.Explosiveness = explosiveness;
            this.Rushing = rushing;
            this.Passing = passing;
            this.StandardDowns = standardDowns;
            this.PassingDowns = passingDowns;
            this.RunRate = runRate;
            this.Pace = pace;
        }
        
        /// <summary>
        /// Gets or Sets Rating
        /// </summary>
        [DataMember(Name="rating", EmitDefaultValue=false)]
        public decimal? Rating { get; set; }

        /// <summary>
        /// Gets or Sets Success
        /// </summary>
        [DataMember(Name="success", EmitDefaultValue=false)]
        public decimal? Success { get; set; }

        /// <summary>
        /// Gets or Sets Explosiveness
        /// </summary>
        [DataMember(Name="explosiveness", EmitDefaultValue=false)]
        public decimal? Explosiveness { get; set; }

        /// <summary>
        /// Gets or Sets Rushing
        /// </summary>
        [DataMember(Name="rushing", EmitDefaultValue=false)]
        public decimal? Rushing { get; set; }

        /// <summary>
        /// Gets or Sets Passing
        /// </summary>
        [DataMember(Name="passing", EmitDefaultValue=false)]
        public decimal? Passing { get; set; }

        /// <summary>
        /// Gets or Sets StandardDowns
        /// </summary>
        [DataMember(Name="standardDowns", EmitDefaultValue=false)]
        public decimal? StandardDowns { get; set; }

        /// <summary>
        /// Gets or Sets PassingDowns
        /// </summary>
        [DataMember(Name="passingDowns", EmitDefaultValue=false)]
        public decimal? PassingDowns { get; set; }

        /// <summary>
        /// Gets or Sets RunRate
        /// </summary>
        [DataMember(Name="runRate", EmitDefaultValue=false)]
        public decimal? RunRate { get; set; }

        /// <summary>
        /// Gets or Sets Pace
        /// </summary>
        [DataMember(Name="pace", EmitDefaultValue=false)]
        public decimal? Pace { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConferenceSPRatingOffense {\n");
            sb.Append("  Rating: ").Append(Rating).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  Explosiveness: ").Append(Explosiveness).Append("\n");
            sb.Append("  Rushing: ").Append(Rushing).Append("\n");
            sb.Append("  Passing: ").Append(Passing).Append("\n");
            sb.Append("  StandardDowns: ").Append(StandardDowns).Append("\n");
            sb.Append("  PassingDowns: ").Append(PassingDowns).Append("\n");
            sb.Append("  RunRate: ").Append(RunRate).Append("\n");
            sb.Append("  Pace: ").Append(Pace).Append("\n");
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
            return this.Equals(input as ConferenceSPRatingOffense);
        }

        /// <summary>
        /// Returns true if ConferenceSPRatingOffense instances are equal
        /// </summary>
        /// <param name="input">Instance of ConferenceSPRatingOffense to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConferenceSPRatingOffense input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Rating == input.Rating ||
                    (this.Rating != null &&
                    this.Rating.Equals(input.Rating))
                ) && 
                (
                    this.Success == input.Success ||
                    (this.Success != null &&
                    this.Success.Equals(input.Success))
                ) && 
                (
                    this.Explosiveness == input.Explosiveness ||
                    (this.Explosiveness != null &&
                    this.Explosiveness.Equals(input.Explosiveness))
                ) && 
                (
                    this.Rushing == input.Rushing ||
                    (this.Rushing != null &&
                    this.Rushing.Equals(input.Rushing))
                ) && 
                (
                    this.Passing == input.Passing ||
                    (this.Passing != null &&
                    this.Passing.Equals(input.Passing))
                ) && 
                (
                    this.StandardDowns == input.StandardDowns ||
                    (this.StandardDowns != null &&
                    this.StandardDowns.Equals(input.StandardDowns))
                ) && 
                (
                    this.PassingDowns == input.PassingDowns ||
                    (this.PassingDowns != null &&
                    this.PassingDowns.Equals(input.PassingDowns))
                ) && 
                (
                    this.RunRate == input.RunRate ||
                    (this.RunRate != null &&
                    this.RunRate.Equals(input.RunRate))
                ) && 
                (
                    this.Pace == input.Pace ||
                    (this.Pace != null &&
                    this.Pace.Equals(input.Pace))
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
                if (this.Success != null)
                    hashCode = hashCode * 59 + this.Success.GetHashCode();
                if (this.Explosiveness != null)
                    hashCode = hashCode * 59 + this.Explosiveness.GetHashCode();
                if (this.Rushing != null)
                    hashCode = hashCode * 59 + this.Rushing.GetHashCode();
                if (this.Passing != null)
                    hashCode = hashCode * 59 + this.Passing.GetHashCode();
                if (this.StandardDowns != null)
                    hashCode = hashCode * 59 + this.StandardDowns.GetHashCode();
                if (this.PassingDowns != null)
                    hashCode = hashCode * 59 + this.PassingDowns.GetHashCode();
                if (this.RunRate != null)
                    hashCode = hashCode * 59 + this.RunRate.GetHashCode();
                if (this.Pace != null)
                    hashCode = hashCode * 59 + this.Pace.GetHashCode();
                return hashCode;
            }
        }
    }

}
