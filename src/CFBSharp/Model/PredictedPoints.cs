/* 
 * College Football Data API
 *
 * This is an API for accessing all sorts of college football data.  It currently has a wide array of data ranging from play by play to player statistics to game scores and more.
 *
 * OpenAPI spec version: 2.2.8
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
    /// PredictedPoints
    /// </summary>
    [DataContract]
    public partial class PredictedPoints :  IEquatable<PredictedPoints>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PredictedPoints" /> class.
        /// </summary>
        /// <param name="yardLine">yardLine.</param>
        /// <param name="predictedPoints">predictedPoints.</param>
        public PredictedPoints(int? yardLine = default(int?), decimal? predictedPoints = default(decimal?))
        {
            this.YardLine = yardLine;
            this._PredictedPoints = predictedPoints;
        }
        
        /// <summary>
        /// Gets or Sets YardLine
        /// </summary>
        [DataMember(Name="yardLine", EmitDefaultValue=false)]
        public int? YardLine { get; set; }

        /// <summary>
        /// Gets or Sets _PredictedPoints
        /// </summary>
        [DataMember(Name="predictedPoints", EmitDefaultValue=false)]
        public decimal? _PredictedPoints { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PredictedPoints {\n");
            sb.Append("  YardLine: ").Append(YardLine).Append("\n");
            sb.Append("  _PredictedPoints: ").Append(_PredictedPoints).Append("\n");
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
            return this.Equals(input as PredictedPoints);
        }

        /// <summary>
        /// Returns true if PredictedPoints instances are equal
        /// </summary>
        /// <param name="input">Instance of PredictedPoints to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PredictedPoints input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.YardLine == input.YardLine ||
                    (this.YardLine != null &&
                    this.YardLine.Equals(input.YardLine))
                ) && 
                (
                    this._PredictedPoints == input._PredictedPoints ||
                    (this._PredictedPoints != null &&
                    this._PredictedPoints.Equals(input._PredictedPoints))
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
                if (this.YardLine != null)
                    hashCode = hashCode * 59 + this.YardLine.GetHashCode();
                if (this._PredictedPoints != null)
                    hashCode = hashCode * 59 + this._PredictedPoints.GetHashCode();
                return hashCode;
            }
        }
    }

}
