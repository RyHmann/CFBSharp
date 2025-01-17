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
    /// PlayerGamePPAAveragePPA
    /// </summary>
    [DataContract]
    public partial class PlayerGamePPAAveragePPA :  IEquatable<PlayerGamePPAAveragePPA>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerGamePPAAveragePPA" /> class.
        /// </summary>
        /// <param name="all">all.</param>
        /// <param name="pass">pass.</param>
        /// <param name="rush">rush.</param>
        public PlayerGamePPAAveragePPA(decimal? all = default(decimal?), decimal? pass = default(decimal?), decimal? rush = default(decimal?))
        {
            this.All = all;
            this.Pass = pass;
            this.Rush = rush;
        }
        
        /// <summary>
        /// Gets or Sets All
        /// </summary>
        [DataMember(Name="all", EmitDefaultValue=false)]
        public decimal? All { get; set; }

        /// <summary>
        /// Gets or Sets Pass
        /// </summary>
        [DataMember(Name="pass", EmitDefaultValue=false)]
        public decimal? Pass { get; set; }

        /// <summary>
        /// Gets or Sets Rush
        /// </summary>
        [DataMember(Name="rush", EmitDefaultValue=false)]
        public decimal? Rush { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlayerGamePPAAveragePPA {\n");
            sb.Append("  All: ").Append(All).Append("\n");
            sb.Append("  Pass: ").Append(Pass).Append("\n");
            sb.Append("  Rush: ").Append(Rush).Append("\n");
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
            return this.Equals(input as PlayerGamePPAAveragePPA);
        }

        /// <summary>
        /// Returns true if PlayerGamePPAAveragePPA instances are equal
        /// </summary>
        /// <param name="input">Instance of PlayerGamePPAAveragePPA to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlayerGamePPAAveragePPA input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.All == input.All ||
                    (this.All != null &&
                    this.All.Equals(input.All))
                ) && 
                (
                    this.Pass == input.Pass ||
                    (this.Pass != null &&
                    this.Pass.Equals(input.Pass))
                ) && 
                (
                    this.Rush == input.Rush ||
                    (this.Rush != null &&
                    this.Rush.Equals(input.Rush))
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
                if (this.All != null)
                    hashCode = hashCode * 59 + this.All.GetHashCode();
                if (this.Pass != null)
                    hashCode = hashCode * 59 + this.Pass.GetHashCode();
                if (this.Rush != null)
                    hashCode = hashCode * 59 + this.Rush.GetHashCode();
                return hashCode;
            }
        }
    }

}
