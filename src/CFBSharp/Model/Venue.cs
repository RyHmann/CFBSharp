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
    /// Venue
    /// </summary>
    [DataContract]
    public partial class Venue :  IEquatable<Venue>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Venue" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="capacity">capacity.</param>
        /// <param name="grass">grass.</param>
        /// <param name="city">city.</param>
        /// <param name="state">state.</param>
        /// <param name="zip">zip.</param>
        /// <param name="countryCode">countryCode.</param>
        /// <param name="location">location.</param>
        /// <param name="elevation">elevation.</param>
        /// <param name="yearConstructed">yearConstructed.</param>
        /// <param name="dome">dome.</param>
        /// <param name="timezone">timezone.</param>
        public Venue(int? id = default(int?), string name = default(string), int? capacity = default(int?), bool? grass = default(bool?), string city = default(string), string state = default(string), string zip = default(string), string countryCode = default(string), VenueLocation location = default(VenueLocation), decimal? elevation = default(decimal?), int? yearConstructed = default(int?), bool? dome = default(bool?), string timezone = default(string))
        {
            this.Id = id;
            this.Name = name;
            this.Capacity = capacity;
            this.Grass = grass;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.CountryCode = countryCode;
            this.Location = location;
            this.Elevation = elevation;
            this.YearConstructed = yearConstructed;
            this.Dome = dome;
            this.Timezone = timezone;
        }
        
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
        /// Gets or Sets Capacity
        /// </summary>
        [DataMember(Name="capacity", EmitDefaultValue=false)]
        public int? Capacity { get; set; }

        /// <summary>
        /// Gets or Sets Grass
        /// </summary>
        [DataMember(Name="grass", EmitDefaultValue=false)]
        public bool? Grass { get; set; }

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
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public VenueLocation Location { get; set; }

        /// <summary>
        /// Gets or Sets Elevation
        /// </summary>
        [DataMember(Name="elevation", EmitDefaultValue=false)]
        public decimal? Elevation { get; set; }

        /// <summary>
        /// Gets or Sets YearConstructed
        /// </summary>
        [DataMember(Name="year_constructed", EmitDefaultValue=false)]
        public int? YearConstructed { get; set; }

        /// <summary>
        /// Gets or Sets Dome
        /// </summary>
        [DataMember(Name="dome", EmitDefaultValue=false)]
        public bool? Dome { get; set; }

        /// <summary>
        /// Gets or Sets Timezone
        /// </summary>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Venue {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Capacity: ").Append(Capacity).Append("\n");
            sb.Append("  Grass: ").Append(Grass).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Elevation: ").Append(Elevation).Append("\n");
            sb.Append("  YearConstructed: ").Append(YearConstructed).Append("\n");
            sb.Append("  Dome: ").Append(Dome).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
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
            return this.Equals(input as Venue);
        }

        /// <summary>
        /// Returns true if Venue instances are equal
        /// </summary>
        /// <param name="input">Instance of Venue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Venue input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Capacity == input.Capacity ||
                    (this.Capacity != null &&
                    this.Capacity.Equals(input.Capacity))
                ) && 
                (
                    this.Grass == input.Grass ||
                    (this.Grass != null &&
                    this.Grass.Equals(input.Grass))
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
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.Elevation == input.Elevation ||
                    (this.Elevation != null &&
                    this.Elevation.Equals(input.Elevation))
                ) && 
                (
                    this.YearConstructed == input.YearConstructed ||
                    (this.YearConstructed != null &&
                    this.YearConstructed.Equals(input.YearConstructed))
                ) && 
                (
                    this.Dome == input.Dome ||
                    (this.Dome != null &&
                    this.Dome.Equals(input.Dome))
                ) && 
                (
                    this.Timezone == input.Timezone ||
                    (this.Timezone != null &&
                    this.Timezone.Equals(input.Timezone))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Capacity != null)
                    hashCode = hashCode * 59 + this.Capacity.GetHashCode();
                if (this.Grass != null)
                    hashCode = hashCode * 59 + this.Grass.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Zip != null)
                    hashCode = hashCode * 59 + this.Zip.GetHashCode();
                if (this.CountryCode != null)
                    hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.Elevation != null)
                    hashCode = hashCode * 59 + this.Elevation.GetHashCode();
                if (this.YearConstructed != null)
                    hashCode = hashCode * 59 + this.YearConstructed.GetHashCode();
                if (this.Dome != null)
                    hashCode = hashCode * 59 + this.Dome.GetHashCode();
                if (this.Timezone != null)
                    hashCode = hashCode * 59 + this.Timezone.GetHashCode();
                return hashCode;
            }
        }
    }

}
