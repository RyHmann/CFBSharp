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
    /// TeamLocation
    /// </summary>
    [DataContract]
    public partial class TeamLocation :  IEquatable<TeamLocation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamLocation" /> class.
        /// </summary>
        /// <param name="venueId">venueId.</param>
        /// <param name="name">name.</param>
        /// <param name="city">city.</param>
        /// <param name="state">state.</param>
        /// <param name="zip">zip.</param>
        /// <param name="countryCode">countryCode.</param>
        /// <param name="timezone">timezone.</param>
        /// <param name="latitude">latitude.</param>
        /// <param name="longitude">longitude.</param>
        /// <param name="elevation">elevation.</param>
        /// <param name="capacity">capacity.</param>
        /// <param name="yearConstructed">yearConstructed.</param>
        /// <param name="grass">grass.</param>
        /// <param name="dome">dome.</param>
        public TeamLocation(int? venueId = default(int?), string name = default(string), string city = default(string), string state = default(string), string zip = default(string), string countryCode = default(string), string timezone = default(string), decimal? latitude = default(decimal?), decimal? longitude = default(decimal?), decimal? elevation = default(decimal?), decimal? capacity = default(decimal?), decimal? yearConstructed = default(decimal?), bool? grass = default(bool?), bool? dome = default(bool?))
        {
            this.VenueId = venueId;
            this.Name = name;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.CountryCode = countryCode;
            this.Timezone = timezone;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Elevation = elevation;
            this.Capacity = capacity;
            this.YearConstructed = yearConstructed;
            this.Grass = grass;
            this.Dome = dome;
        }
        
        /// <summary>
        /// Gets or Sets VenueId
        /// </summary>
        [DataMember(Name="venue_id", EmitDefaultValue=false)]
        public int? VenueId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets Zip
        /// </summary>
        [DataMember(Name="zip", EmitDefaultValue=false)]
        public string Zip { get; set; }

        /// <summary>
        /// Gets or Sets CountryCode
        /// </summary>
        [DataMember(Name="country_code", EmitDefaultValue=false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or Sets Timezone
        /// </summary>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// Gets or Sets Latitude
        /// </summary>
        [DataMember(Name="latitude", EmitDefaultValue=false)]
        public decimal? Latitude { get; set; }

        /// <summary>
        /// Gets or Sets Longitude
        /// </summary>
        [DataMember(Name="longitude", EmitDefaultValue=false)]
        public decimal? Longitude { get; set; }

        /// <summary>
        /// Gets or Sets Elevation
        /// </summary>
        [DataMember(Name="elevation", EmitDefaultValue=false)]
        public decimal? Elevation { get; set; }

        /// <summary>
        /// Gets or Sets Capacity
        /// </summary>
        [DataMember(Name="capacity", EmitDefaultValue=false)]
        public decimal? Capacity { get; set; }

        /// <summary>
        /// Gets or Sets YearConstructed
        /// </summary>
        [DataMember(Name="year_constructed", EmitDefaultValue=false)]
        public decimal? YearConstructed { get; set; }

        /// <summary>
        /// Gets or Sets Grass
        /// </summary>
        [DataMember(Name="grass", EmitDefaultValue=false)]
        public bool? Grass { get; set; }

        /// <summary>
        /// Gets or Sets Dome
        /// </summary>
        [DataMember(Name="dome", EmitDefaultValue=false)]
        public bool? Dome { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeamLocation {\n");
            sb.Append("  VenueId: ").Append(VenueId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  Elevation: ").Append(Elevation).Append("\n");
            sb.Append("  Capacity: ").Append(Capacity).Append("\n");
            sb.Append("  YearConstructed: ").Append(YearConstructed).Append("\n");
            sb.Append("  Grass: ").Append(Grass).Append("\n");
            sb.Append("  Dome: ").Append(Dome).Append("\n");
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
            return this.Equals(input as TeamLocation);
        }

        /// <summary>
        /// Returns true if TeamLocation instances are equal
        /// </summary>
        /// <param name="input">Instance of TeamLocation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeamLocation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VenueId == input.VenueId ||
                    (this.VenueId != null &&
                    this.VenueId.Equals(input.VenueId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Zip == input.Zip ||
                    (this.Zip != null &&
                    this.Zip.Equals(input.Zip))
                ) && 
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
                ) && 
                (
                    this.Timezone == input.Timezone ||
                    (this.Timezone != null &&
                    this.Timezone.Equals(input.Timezone))
                ) && 
                (
                    this.Latitude == input.Latitude ||
                    (this.Latitude != null &&
                    this.Latitude.Equals(input.Latitude))
                ) && 
                (
                    this.Longitude == input.Longitude ||
                    (this.Longitude != null &&
                    this.Longitude.Equals(input.Longitude))
                ) && 
                (
                    this.Elevation == input.Elevation ||
                    (this.Elevation != null &&
                    this.Elevation.Equals(input.Elevation))
                ) && 
                (
                    this.Capacity == input.Capacity ||
                    (this.Capacity != null &&
                    this.Capacity.Equals(input.Capacity))
                ) && 
                (
                    this.YearConstructed == input.YearConstructed ||
                    (this.YearConstructed != null &&
                    this.YearConstructed.Equals(input.YearConstructed))
                ) && 
                (
                    this.Grass == input.Grass ||
                    (this.Grass != null &&
                    this.Grass.Equals(input.Grass))
                ) && 
                (
                    this.Dome == input.Dome ||
                    (this.Dome != null &&
                    this.Dome.Equals(input.Dome))
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
                if (this.VenueId != null)
                    hashCode = hashCode * 59 + this.VenueId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Zip != null)
                    hashCode = hashCode * 59 + this.Zip.GetHashCode();
                if (this.CountryCode != null)
                    hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
                if (this.Timezone != null)
                    hashCode = hashCode * 59 + this.Timezone.GetHashCode();
                if (this.Latitude != null)
                    hashCode = hashCode * 59 + this.Latitude.GetHashCode();
                if (this.Longitude != null)
                    hashCode = hashCode * 59 + this.Longitude.GetHashCode();
                if (this.Elevation != null)
                    hashCode = hashCode * 59 + this.Elevation.GetHashCode();
                if (this.Capacity != null)
                    hashCode = hashCode * 59 + this.Capacity.GetHashCode();
                if (this.YearConstructed != null)
                    hashCode = hashCode * 59 + this.YearConstructed.GetHashCode();
                if (this.Grass != null)
                    hashCode = hashCode * 59 + this.Grass.GetHashCode();
                if (this.Dome != null)
                    hashCode = hashCode * 59 + this.Dome.GetHashCode();
                return hashCode;
            }
        }
    }

}
