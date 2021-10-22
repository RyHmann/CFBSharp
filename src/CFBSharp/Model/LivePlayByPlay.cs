/* 
 * College Football Data API
 *
 * This is an API for accessing all sorts of college football data.  Please note that API keys should be supplied with \"Bearer \" prepended (e.g. \"Bearer your_key\"). API keys can be acquired from the CollegeFootballData.com website.
 *
 * OpenAPI spec version: 4.2.1
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
    /// LivePlayByPlay
    /// </summary>
    [DataContract]
    public partial class LivePlayByPlay :  IEquatable<LivePlayByPlay>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LivePlayByPlay" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="teams">teams.</param>
        /// <param name="plays">plays.</param>
        public LivePlayByPlay(int? id = default(int?), List<Object> teams = default(List<Object>), List<Object> plays = default(List<Object>))
        {
            this.Id = id;
            this.Teams = teams;
            this.Plays = plays;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Teams
        /// </summary>
        [DataMember(Name="teams", EmitDefaultValue=false)]
        public List<Object> Teams { get; set; }

        /// <summary>
        /// Gets or Sets Plays
        /// </summary>
        [DataMember(Name="plays", EmitDefaultValue=false)]
        public List<Object> Plays { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LivePlayByPlay {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Teams: ").Append(Teams).Append("\n");
            sb.Append("  Plays: ").Append(Plays).Append("\n");
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
            return this.Equals(input as LivePlayByPlay);
        }

        /// <summary>
        /// Returns true if LivePlayByPlay instances are equal
        /// </summary>
        /// <param name="input">Instance of LivePlayByPlay to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LivePlayByPlay input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Teams == input.Teams ||
                    this.Teams != null &&
                    this.Teams.SequenceEqual(input.Teams)
                ) && 
                (
                    this.Plays == input.Plays ||
                    this.Plays != null &&
                    this.Plays.SequenceEqual(input.Plays)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Teams != null)
                    hashCode = hashCode * 59 + this.Teams.GetHashCode();
                if (this.Plays != null)
                    hashCode = hashCode * 59 + this.Plays.GetHashCode();
                return hashCode;
            }
        }
    }

}
