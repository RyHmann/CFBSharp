/* 
 * College Football Data API
 *
 * This is an API for accessing all sorts of college football data.  Please note that API keys should be supplied with \"Bearer \" prepended (e.g. \"Bearer your_key\"). API keys can be acquired from the CollegeFootballData.com website.
 *
 * OpenAPI spec version: 4.4.3
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
    /// PortalPlayer
    /// </summary>
    [DataContract]
    public partial class PortalPlayer :  IEquatable<PortalPlayer>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PortalPlayer" /> class.
        /// </summary>
        /// <param name="season">season.</param>
        /// <param name="firstName">firstName.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="position">position.</param>
        /// <param name="origin">origin.</param>
        /// <param name="destination">destination.</param>
        /// <param name="transferDate">transferDate.</param>
        /// <param name="rating">rating.</param>
        /// <param name="stars">stars.</param>
        /// <param name="eligibility">eligibility.</param>
        public PortalPlayer(int? season = default(int?), string firstName = default(string), string lastName = default(string), string position = default(string), string origin = default(string), string destination = default(string), string transferDate = default(string), decimal? rating = default(decimal?), int? stars = default(int?), string eligibility = default(string))
        {
            this.Season = season;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Position = position;
            this.Origin = origin;
            this.Destination = destination;
            this.TransferDate = transferDate;
            this.Rating = rating;
            this.Stars = stars;
            this.Eligibility = eligibility;
        }
        
        /// <summary>
        /// Gets or Sets Season
        /// </summary>
        [DataMember(Name="season", EmitDefaultValue=false)]
        public int? Season { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public string Position { get; set; }

        /// <summary>
        /// Gets or Sets Origin
        /// </summary>
        [DataMember(Name="origin", EmitDefaultValue=false)]
        public string Origin { get; set; }

        /// <summary>
        /// Gets or Sets Destination
        /// </summary>
        [DataMember(Name="destination", EmitDefaultValue=false)]
        public string Destination { get; set; }

        /// <summary>
        /// Gets or Sets TransferDate
        /// </summary>
        [DataMember(Name="transferDate", EmitDefaultValue=false)]
        public string TransferDate { get; set; }

        /// <summary>
        /// Gets or Sets Rating
        /// </summary>
        [DataMember(Name="rating", EmitDefaultValue=false)]
        public decimal? Rating { get; set; }

        /// <summary>
        /// Gets or Sets Stars
        /// </summary>
        [DataMember(Name="stars", EmitDefaultValue=false)]
        public int? Stars { get; set; }

        /// <summary>
        /// Gets or Sets Eligibility
        /// </summary>
        [DataMember(Name="eligibility", EmitDefaultValue=false)]
        public string Eligibility { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PortalPlayer {\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
            sb.Append("  Destination: ").Append(Destination).Append("\n");
            sb.Append("  TransferDate: ").Append(TransferDate).Append("\n");
            sb.Append("  Rating: ").Append(Rating).Append("\n");
            sb.Append("  Stars: ").Append(Stars).Append("\n");
            sb.Append("  Eligibility: ").Append(Eligibility).Append("\n");
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
            return this.Equals(input as PortalPlayer);
        }

        /// <summary>
        /// Returns true if PortalPlayer instances are equal
        /// </summary>
        /// <param name="input">Instance of PortalPlayer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PortalPlayer input)
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
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.Position == input.Position ||
                    (this.Position != null &&
                    this.Position.Equals(input.Position))
                ) && 
                (
                    this.Origin == input.Origin ||
                    (this.Origin != null &&
                    this.Origin.Equals(input.Origin))
                ) && 
                (
                    this.Destination == input.Destination ||
                    (this.Destination != null &&
                    this.Destination.Equals(input.Destination))
                ) && 
                (
                    this.TransferDate == input.TransferDate ||
                    (this.TransferDate != null &&
                    this.TransferDate.Equals(input.TransferDate))
                ) && 
                (
                    this.Rating == input.Rating ||
                    (this.Rating != null &&
                    this.Rating.Equals(input.Rating))
                ) && 
                (
                    this.Stars == input.Stars ||
                    (this.Stars != null &&
                    this.Stars.Equals(input.Stars))
                ) && 
                (
                    this.Eligibility == input.Eligibility ||
                    (this.Eligibility != null &&
                    this.Eligibility.Equals(input.Eligibility))
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
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.Position != null)
                    hashCode = hashCode * 59 + this.Position.GetHashCode();
                if (this.Origin != null)
                    hashCode = hashCode * 59 + this.Origin.GetHashCode();
                if (this.Destination != null)
                    hashCode = hashCode * 59 + this.Destination.GetHashCode();
                if (this.TransferDate != null)
                    hashCode = hashCode * 59 + this.TransferDate.GetHashCode();
                if (this.Rating != null)
                    hashCode = hashCode * 59 + this.Rating.GetHashCode();
                if (this.Stars != null)
                    hashCode = hashCode * 59 + this.Stars.GetHashCode();
                if (this.Eligibility != null)
                    hashCode = hashCode * 59 + this.Eligibility.GetHashCode();
                return hashCode;
            }
        }
    }

}
