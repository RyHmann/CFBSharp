/* 
 * College Football Data API
 *
 * This is an API for accessing all sorts of college football data.  It currently has a wide array of data ranging from play by play to player statistics to game scores and more.
 *
 * OpenAPI spec version: 2.4.1
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
    /// PlayerSeasonPPA
    /// </summary>
    [DataContract]
    public partial class PlayerSeasonPPA :  IEquatable<PlayerSeasonPPA>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerSeasonPPA" /> class.
        /// </summary>
        /// <param name="season">season.</param>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="position">position.</param>
        /// <param name="team">team.</param>
        /// <param name="conference">conference.</param>
        /// <param name="averagePPA">averagePPA.</param>
        /// <param name="totalPPA">totalPPA.</param>
        public PlayerSeasonPPA(int? season = default(int?), int? id = default(int?), string name = default(string), string position = default(string), string team = default(string), string conference = default(string), PlayerSeasonPPAAveragePPA averagePPA = default(PlayerSeasonPPAAveragePPA), PlayerSeasonPPAAveragePPA totalPPA = default(PlayerSeasonPPAAveragePPA))
        {
            this.Season = season;
            this.Id = id;
            this.Name = name;
            this.Position = position;
            this.Team = team;
            this.Conference = conference;
            this.AveragePPA = averagePPA;
            this.TotalPPA = totalPPA;
        }
        
        /// <summary>
        /// Gets or Sets Season
        /// </summary>
        [DataMember(Name="season", EmitDefaultValue=false)]
        public int? Season { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public string Position { get; set; }

        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name="team", EmitDefaultValue=false)]
        public string Team { get; set; }

        /// <summary>
        /// Gets or Sets Conference
        /// </summary>
        [DataMember(Name="conference", EmitDefaultValue=false)]
        public string Conference { get; set; }

        /// <summary>
        /// Gets or Sets AveragePPA
        /// </summary>
        [DataMember(Name="averagePPA", EmitDefaultValue=false)]
        public PlayerSeasonPPAAveragePPA AveragePPA { get; set; }

        /// <summary>
        /// Gets or Sets TotalPPA
        /// </summary>
        [DataMember(Name="totalPPA", EmitDefaultValue=false)]
        public PlayerSeasonPPAAveragePPA TotalPPA { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlayerSeasonPPA {\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Conference: ").Append(Conference).Append("\n");
            sb.Append("  AveragePPA: ").Append(AveragePPA).Append("\n");
            sb.Append("  TotalPPA: ").Append(TotalPPA).Append("\n");
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
            return this.Equals(input as PlayerSeasonPPA);
        }

        /// <summary>
        /// Returns true if PlayerSeasonPPA instances are equal
        /// </summary>
        /// <param name="input">Instance of PlayerSeasonPPA to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlayerSeasonPPA input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Season == input.Season ||
                    (this.Season != null &&
                    this.Season.Equals(input.Season))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Position == input.Position ||
                    (this.Position != null &&
                    this.Position.Equals(input.Position))
                ) && 
                (
                    this.Team == input.Team ||
                    (this.Team != null &&
                    this.Team.Equals(input.Team))
                ) && 
                (
                    this.Conference == input.Conference ||
                    (this.Conference != null &&
                    this.Conference.Equals(input.Conference))
                ) && 
                (
                    this.AveragePPA == input.AveragePPA ||
                    (this.AveragePPA != null &&
                    this.AveragePPA.Equals(input.AveragePPA))
                ) && 
                (
                    this.TotalPPA == input.TotalPPA ||
                    (this.TotalPPA != null &&
                    this.TotalPPA.Equals(input.TotalPPA))
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
                if (this.Season != null)
                    hashCode = hashCode * 59 + this.Season.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Position != null)
                    hashCode = hashCode * 59 + this.Position.GetHashCode();
                if (this.Team != null)
                    hashCode = hashCode * 59 + this.Team.GetHashCode();
                if (this.Conference != null)
                    hashCode = hashCode * 59 + this.Conference.GetHashCode();
                if (this.AveragePPA != null)
                    hashCode = hashCode * 59 + this.AveragePPA.GetHashCode();
                if (this.TotalPPA != null)
                    hashCode = hashCode * 59 + this.TotalPPA.GetHashCode();
                return hashCode;
            }
        }
    }

}
