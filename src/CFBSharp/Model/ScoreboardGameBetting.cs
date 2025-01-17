/* 
 * College Football Data API
 *
 * This is an API for accessing all sorts of college football data.  Please note that API keys should be supplied with \"Bearer \" prepended (e.g. \"Bearer your_key\"). API keys can be acquired from the CollegeFootballData.com website.
 *
 * OpenAPI spec version: 4.4.12
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
    /// ScoreboardGameBetting
    /// </summary>
    [DataContract]
    public partial class ScoreboardGameBetting :  IEquatable<ScoreboardGameBetting>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreboardGameBetting" /> class.
        /// </summary>
        /// <param name="spread">spread.</param>
        /// <param name="overUnder">overUnder.</param>
        /// <param name="homeMoneyline">homeMoneyline.</param>
        /// <param name="awayMoneyline">awayMoneyline.</param>
        public ScoreboardGameBetting(decimal? spread = default(decimal?), decimal? overUnder = default(decimal?), int? homeMoneyline = default(int?), int? awayMoneyline = default(int?))
        {
            this.Spread = spread;
            this.OverUnder = overUnder;
            this.HomeMoneyline = homeMoneyline;
            this.AwayMoneyline = awayMoneyline;
        }
        
        /// <summary>
        /// Gets or Sets Spread
        /// </summary>
        [DataMember(Name="spread", EmitDefaultValue=false)]
        public decimal? Spread { get; set; }

        /// <summary>
        /// Gets or Sets OverUnder
        /// </summary>
        [DataMember(Name="overUnder", EmitDefaultValue=false)]
        public decimal? OverUnder { get; set; }

        /// <summary>
        /// Gets or Sets HomeMoneyline
        /// </summary>
        [DataMember(Name="homeMoneyline", EmitDefaultValue=false)]
        public int? HomeMoneyline { get; set; }

        /// <summary>
        /// Gets or Sets AwayMoneyline
        /// </summary>
        [DataMember(Name="awayMoneyline", EmitDefaultValue=false)]
        public int? AwayMoneyline { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScoreboardGameBetting {\n");
            sb.Append("  Spread: ").Append(Spread).Append("\n");
            sb.Append("  OverUnder: ").Append(OverUnder).Append("\n");
            sb.Append("  HomeMoneyline: ").Append(HomeMoneyline).Append("\n");
            sb.Append("  AwayMoneyline: ").Append(AwayMoneyline).Append("\n");
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
            return this.Equals(input as ScoreboardGameBetting);
        }

        /// <summary>
        /// Returns true if ScoreboardGameBetting instances are equal
        /// </summary>
        /// <param name="input">Instance of ScoreboardGameBetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScoreboardGameBetting input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Spread == input.Spread ||
                    (this.Spread != null &&
                    this.Spread.Equals(input.Spread))
                ) && 
                (
                    this.OverUnder == input.OverUnder ||
                    (this.OverUnder != null &&
                    this.OverUnder.Equals(input.OverUnder))
                ) && 
                (
                    this.HomeMoneyline == input.HomeMoneyline ||
                    (this.HomeMoneyline != null &&
                    this.HomeMoneyline.Equals(input.HomeMoneyline))
                ) && 
                (
                    this.AwayMoneyline == input.AwayMoneyline ||
                    (this.AwayMoneyline != null &&
                    this.AwayMoneyline.Equals(input.AwayMoneyline))
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
                if (this.Spread != null)
                    hashCode = hashCode * 59 + this.Spread.GetHashCode();
                if (this.OverUnder != null)
                    hashCode = hashCode * 59 + this.OverUnder.GetHashCode();
                if (this.HomeMoneyline != null)
                    hashCode = hashCode * 59 + this.HomeMoneyline.GetHashCode();
                if (this.AwayMoneyline != null)
                    hashCode = hashCode * 59 + this.AwayMoneyline.GetHashCode();
                return hashCode;
            }
        }
    }

}
