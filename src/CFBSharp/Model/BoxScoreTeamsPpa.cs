/* 
 * College Football Data API
 *
 * This is an API for accessing all sorts of college football data.  It currently has a wide array of data ranging from play by play to player statistics to game scores and more.
 *
 * OpenAPI spec version: 2.2.12
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
    /// BoxScoreTeamsPpa
    /// </summary>
    [DataContract]
    public partial class BoxScoreTeamsPpa :  IEquatable<BoxScoreTeamsPpa>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BoxScoreTeamsPpa" /> class.
        /// </summary>
        /// <param name="team">team.</param>
        /// <param name="overall">overall.</param>
        /// <param name="passing">passing.</param>
        /// <param name="rushing">rushing.</param>
        public BoxScoreTeamsPpa(string team = default(string), BoxScoreTeamsOverall overall = default(BoxScoreTeamsOverall), BoxScoreTeamsOverall passing = default(BoxScoreTeamsOverall), BoxScoreTeamsOverall rushing = default(BoxScoreTeamsOverall))
        {
            this.Team = team;
            this.Overall = overall;
            this.Passing = passing;
            this.Rushing = rushing;
        }
        
        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name="team", EmitDefaultValue=false)]
        public string Team { get; set; }

        /// <summary>
        /// Gets or Sets Overall
        /// </summary>
        [DataMember(Name="overall", EmitDefaultValue=false)]
        public BoxScoreTeamsOverall Overall { get; set; }

        /// <summary>
        /// Gets or Sets Passing
        /// </summary>
        [DataMember(Name="passing", EmitDefaultValue=false)]
        public BoxScoreTeamsOverall Passing { get; set; }

        /// <summary>
        /// Gets or Sets Rushing
        /// </summary>
        [DataMember(Name="rushing", EmitDefaultValue=false)]
        public BoxScoreTeamsOverall Rushing { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BoxScoreTeamsPpa {\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Overall: ").Append(Overall).Append("\n");
            sb.Append("  Passing: ").Append(Passing).Append("\n");
            sb.Append("  Rushing: ").Append(Rushing).Append("\n");
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
            return this.Equals(input as BoxScoreTeamsPpa);
        }

        /// <summary>
        /// Returns true if BoxScoreTeamsPpa instances are equal
        /// </summary>
        /// <param name="input">Instance of BoxScoreTeamsPpa to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BoxScoreTeamsPpa input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Team == input.Team ||
                    (this.Team != null &&
                    this.Team.Equals(input.Team))
                ) && 
                (
                    this.Overall == input.Overall ||
                    (this.Overall != null &&
                    this.Overall.Equals(input.Overall))
                ) && 
                (
                    this.Passing == input.Passing ||
                    (this.Passing != null &&
                    this.Passing.Equals(input.Passing))
                ) && 
                (
                    this.Rushing == input.Rushing ||
                    (this.Rushing != null &&
                    this.Rushing.Equals(input.Rushing))
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
                if (this.Team != null)
                    hashCode = hashCode * 59 + this.Team.GetHashCode();
                if (this.Overall != null)
                    hashCode = hashCode * 59 + this.Overall.GetHashCode();
                if (this.Passing != null)
                    hashCode = hashCode * 59 + this.Passing.GetHashCode();
                if (this.Rushing != null)
                    hashCode = hashCode * 59 + this.Rushing.GetHashCode();
                return hashCode;
            }
        }
    }

}
