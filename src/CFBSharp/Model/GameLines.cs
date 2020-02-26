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
    /// GameLines
    /// </summary>
    [DataContract]
    public partial class GameLines :  IEquatable<GameLines>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GameLines" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="homeTeam">homeTeam.</param>
        /// <param name="homeScore">homeScore.</param>
        /// <param name="awayTeam">awayTeam.</param>
        /// <param name="awayScore">awayScore.</param>
        /// <param name="lines">lines.</param>
        public GameLines(int? id = default(int?), string homeTeam = default(string), int? homeScore = default(int?), string awayTeam = default(string), int? awayScore = default(int?), List<GameLinesLines> lines = default(List<GameLinesLines>))
        {
            this.Id = id;
            this.HomeTeam = homeTeam;
            this.HomeScore = homeScore;
            this.AwayTeam = awayTeam;
            this.AwayScore = awayScore;
            this.Lines = lines;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets HomeTeam
        /// </summary>
        [DataMember(Name="homeTeam", EmitDefaultValue=false)]
        public string HomeTeam { get; set; }

        /// <summary>
        /// Gets or Sets HomeScore
        /// </summary>
        [DataMember(Name="homeScore", EmitDefaultValue=false)]
        public int? HomeScore { get; set; }

        /// <summary>
        /// Gets or Sets AwayTeam
        /// </summary>
        [DataMember(Name="awayTeam", EmitDefaultValue=false)]
        public string AwayTeam { get; set; }

        /// <summary>
        /// Gets or Sets AwayScore
        /// </summary>
        [DataMember(Name="awayScore", EmitDefaultValue=false)]
        public int? AwayScore { get; set; }

        /// <summary>
        /// Gets or Sets Lines
        /// </summary>
        [DataMember(Name="lines", EmitDefaultValue=false)]
        public List<GameLinesLines> Lines { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GameLines {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  HomeTeam: ").Append(HomeTeam).Append("\n");
            sb.Append("  HomeScore: ").Append(HomeScore).Append("\n");
            sb.Append("  AwayTeam: ").Append(AwayTeam).Append("\n");
            sb.Append("  AwayScore: ").Append(AwayScore).Append("\n");
            sb.Append("  Lines: ").Append(Lines).Append("\n");
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
            return this.Equals(input as GameLines);
        }

        /// <summary>
        /// Returns true if GameLines instances are equal
        /// </summary>
        /// <param name="input">Instance of GameLines to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GameLines input)
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
                    this.HomeTeam == input.HomeTeam ||
                    (this.HomeTeam != null &&
                    this.HomeTeam.Equals(input.HomeTeam))
                ) && 
                (
                    this.HomeScore == input.HomeScore ||
                    (this.HomeScore != null &&
                    this.HomeScore.Equals(input.HomeScore))
                ) && 
                (
                    this.AwayTeam == input.AwayTeam ||
                    (this.AwayTeam != null &&
                    this.AwayTeam.Equals(input.AwayTeam))
                ) && 
                (
                    this.AwayScore == input.AwayScore ||
                    (this.AwayScore != null &&
                    this.AwayScore.Equals(input.AwayScore))
                ) && 
                (
                    this.Lines == input.Lines ||
                    this.Lines != null &&
                    this.Lines.SequenceEqual(input.Lines)
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
                if (this.HomeTeam != null)
                    hashCode = hashCode * 59 + this.HomeTeam.GetHashCode();
                if (this.HomeScore != null)
                    hashCode = hashCode * 59 + this.HomeScore.GetHashCode();
                if (this.AwayTeam != null)
                    hashCode = hashCode * 59 + this.AwayTeam.GetHashCode();
                if (this.AwayScore != null)
                    hashCode = hashCode * 59 + this.AwayScore.GetHashCode();
                if (this.Lines != null)
                    hashCode = hashCode * 59 + this.Lines.GetHashCode();
                return hashCode;
            }
        }
    }

}