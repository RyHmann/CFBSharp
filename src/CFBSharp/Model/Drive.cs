/* 
 * College Football Data API
 *
 * This is an API for accessing all sorts of college football data.  Please note that API keys should be supplied with \"Bearer \" prepended (e.g. \"Bearer your_key\"). API keys can be acquired from the CollegeFootballData.com website.
 *
 * OpenAPI spec version: 4.4.4
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
    /// Drive
    /// </summary>
    [DataContract]
    public partial class Drive :  IEquatable<Drive>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Drive" /> class.
        /// </summary>
        /// <param name="offense">offense.</param>
        /// <param name="offenseConference">offenseConference.</param>
        /// <param name="defense">defense.</param>
        /// <param name="defenseConference">defenseConference.</param>
        /// <param name="gameId">gameId.</param>
        /// <param name="id">id.</param>
        /// <param name="driveNumber">driveNumber.</param>
        /// <param name="scoring">scoring.</param>
        /// <param name="startPeriod">startPeriod.</param>
        /// <param name="startYardline">startYardline.</param>
        /// <param name="startYardsToGoal">startYardsToGoal.</param>
        /// <param name="startTime">startTime.</param>
        /// <param name="endPeriod">endPeriod.</param>
        /// <param name="endYardline">endYardline.</param>
        /// <param name="endYardsToGoal">endYardsToGoal.</param>
        /// <param name="endTime">endTime.</param>
        /// <param name="plays">plays.</param>
        /// <param name="yards">yards.</param>
        /// <param name="driveResult">driveResult.</param>
        /// <param name="isHomeOffense">isHomeOffense.</param>
        /// <param name="startOffenseScore">startOffenseScore.</param>
        /// <param name="startDefenseScore">startDefenseScore.</param>
        /// <param name="endOffenseScore">endOffenseScore.</param>
        /// <param name="endDefenseScore">endDefenseScore.</param>
        public Drive(string offense = default(string), string offenseConference = default(string), string defense = default(string), string defenseConference = default(string), int? gameId = default(int?), int? id = default(int?), int? driveNumber = default(int?), bool? scoring = default(bool?), int? startPeriod = default(int?), int? startYardline = default(int?), int? startYardsToGoal = default(int?), Object startTime = default(Object), int? endPeriod = default(int?), int? endYardline = default(int?), int? endYardsToGoal = default(int?), Object endTime = default(Object), int? plays = default(int?), int? yards = default(int?), string driveResult = default(string), bool? isHomeOffense = default(bool?), int? startOffenseScore = default(int?), int? startDefenseScore = default(int?), int? endOffenseScore = default(int?), int? endDefenseScore = default(int?))
        {
            this.Offense = offense;
            this.OffenseConference = offenseConference;
            this.Defense = defense;
            this.DefenseConference = defenseConference;
            this.GameId = gameId;
            this.Id = id;
            this.DriveNumber = driveNumber;
            this.Scoring = scoring;
            this.StartPeriod = startPeriod;
            this.StartYardline = startYardline;
            this.StartYardsToGoal = startYardsToGoal;
            this.StartTime = startTime;
            this.EndPeriod = endPeriod;
            this.EndYardline = endYardline;
            this.EndYardsToGoal = endYardsToGoal;
            this.EndTime = endTime;
            this.Plays = plays;
            this.Yards = yards;
            this.DriveResult = driveResult;
            this.IsHomeOffense = isHomeOffense;
            this.StartOffenseScore = startOffenseScore;
            this.StartDefenseScore = startDefenseScore;
            this.EndOffenseScore = endOffenseScore;
            this.EndDefenseScore = endDefenseScore;
        }
        
        /// <summary>
        /// Gets or Sets Offense
        /// </summary>
        [DataMember(Name="offense", EmitDefaultValue=false)]
        public string Offense { get; set; }

        /// <summary>
        /// Gets or Sets OffenseConference
        /// </summary>
        [DataMember(Name="offense_conference", EmitDefaultValue=false)]
        public string OffenseConference { get; set; }

        /// <summary>
        /// Gets or Sets Defense
        /// </summary>
        [DataMember(Name="defense", EmitDefaultValue=false)]
        public string Defense { get; set; }

        /// <summary>
        /// Gets or Sets DefenseConference
        /// </summary>
        [DataMember(Name="defense_conference", EmitDefaultValue=false)]
        public string DefenseConference { get; set; }

        /// <summary>
        /// Gets or Sets GameId
        /// </summary>
        [DataMember(Name="game_id", EmitDefaultValue=false)]
        public int? GameId { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets DriveNumber
        /// </summary>
        [DataMember(Name="drive_number", EmitDefaultValue=false)]
        public int? DriveNumber { get; set; }

        /// <summary>
        /// Gets or Sets Scoring
        /// </summary>
        [DataMember(Name="scoring", EmitDefaultValue=false)]
        public bool? Scoring { get; set; }

        /// <summary>
        /// Gets or Sets StartPeriod
        /// </summary>
        [DataMember(Name="start_period", EmitDefaultValue=false)]
        public int? StartPeriod { get; set; }

        /// <summary>
        /// Gets or Sets StartYardline
        /// </summary>
        [DataMember(Name="start_yardline", EmitDefaultValue=false)]
        public int? StartYardline { get; set; }

        /// <summary>
        /// Gets or Sets StartYardsToGoal
        /// </summary>
        [DataMember(Name="start_yards_to_goal", EmitDefaultValue=false)]
        public int? StartYardsToGoal { get; set; }

        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [DataMember(Name="start_time", EmitDefaultValue=false)]
        public Object StartTime { get; set; }

        /// <summary>
        /// Gets or Sets EndPeriod
        /// </summary>
        [DataMember(Name="end_period", EmitDefaultValue=false)]
        public int? EndPeriod { get; set; }

        /// <summary>
        /// Gets or Sets EndYardline
        /// </summary>
        [DataMember(Name="end_yardline", EmitDefaultValue=false)]
        public int? EndYardline { get; set; }

        /// <summary>
        /// Gets or Sets EndYardsToGoal
        /// </summary>
        [DataMember(Name="end_yards_to_goal", EmitDefaultValue=false)]
        public int? EndYardsToGoal { get; set; }

        /// <summary>
        /// Gets or Sets EndTime
        /// </summary>
        [DataMember(Name="end_time", EmitDefaultValue=false)]
        public Object EndTime { get; set; }

        /// <summary>
        /// Gets or Sets Plays
        /// </summary>
        [DataMember(Name="plays", EmitDefaultValue=false)]
        public int? Plays { get; set; }

        /// <summary>
        /// Gets or Sets Yards
        /// </summary>
        [DataMember(Name="yards", EmitDefaultValue=false)]
        public int? Yards { get; set; }

        /// <summary>
        /// Gets or Sets DriveResult
        /// </summary>
        [DataMember(Name="drive_result", EmitDefaultValue=false)]
        public string DriveResult { get; set; }

        /// <summary>
        /// Gets or Sets IsHomeOffense
        /// </summary>
        [DataMember(Name="is_home_offense", EmitDefaultValue=false)]
        public bool? IsHomeOffense { get; set; }

        /// <summary>
        /// Gets or Sets StartOffenseScore
        /// </summary>
        [DataMember(Name="start_offense_score", EmitDefaultValue=false)]
        public int? StartOffenseScore { get; set; }

        /// <summary>
        /// Gets or Sets StartDefenseScore
        /// </summary>
        [DataMember(Name="start_defense_score", EmitDefaultValue=false)]
        public int? StartDefenseScore { get; set; }

        /// <summary>
        /// Gets or Sets EndOffenseScore
        /// </summary>
        [DataMember(Name="end_offense_score", EmitDefaultValue=false)]
        public int? EndOffenseScore { get; set; }

        /// <summary>
        /// Gets or Sets EndDefenseScore
        /// </summary>
        [DataMember(Name="end_defense_score", EmitDefaultValue=false)]
        public int? EndDefenseScore { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Drive {\n");
            sb.Append("  Offense: ").Append(Offense).Append("\n");
            sb.Append("  OffenseConference: ").Append(OffenseConference).Append("\n");
            sb.Append("  Defense: ").Append(Defense).Append("\n");
            sb.Append("  DefenseConference: ").Append(DefenseConference).Append("\n");
            sb.Append("  GameId: ").Append(GameId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DriveNumber: ").Append(DriveNumber).Append("\n");
            sb.Append("  Scoring: ").Append(Scoring).Append("\n");
            sb.Append("  StartPeriod: ").Append(StartPeriod).Append("\n");
            sb.Append("  StartYardline: ").Append(StartYardline).Append("\n");
            sb.Append("  StartYardsToGoal: ").Append(StartYardsToGoal).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndPeriod: ").Append(EndPeriod).Append("\n");
            sb.Append("  EndYardline: ").Append(EndYardline).Append("\n");
            sb.Append("  EndYardsToGoal: ").Append(EndYardsToGoal).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  Plays: ").Append(Plays).Append("\n");
            sb.Append("  Yards: ").Append(Yards).Append("\n");
            sb.Append("  DriveResult: ").Append(DriveResult).Append("\n");
            sb.Append("  IsHomeOffense: ").Append(IsHomeOffense).Append("\n");
            sb.Append("  StartOffenseScore: ").Append(StartOffenseScore).Append("\n");
            sb.Append("  StartDefenseScore: ").Append(StartDefenseScore).Append("\n");
            sb.Append("  EndOffenseScore: ").Append(EndOffenseScore).Append("\n");
            sb.Append("  EndDefenseScore: ").Append(EndDefenseScore).Append("\n");
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
            return this.Equals(input as Drive);
        }

        /// <summary>
        /// Returns true if Drive instances are equal
        /// </summary>
        /// <param name="input">Instance of Drive to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Drive input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Offense == input.Offense ||
                    (this.Offense != null &&
                    this.Offense.Equals(input.Offense))
                ) && 
                (
                    this.OffenseConference == input.OffenseConference ||
                    (this.OffenseConference != null &&
                    this.OffenseConference.Equals(input.OffenseConference))
                ) && 
                (
                    this.Defense == input.Defense ||
                    (this.Defense != null &&
                    this.Defense.Equals(input.Defense))
                ) && 
                (
                    this.DefenseConference == input.DefenseConference ||
                    (this.DefenseConference != null &&
                    this.DefenseConference.Equals(input.DefenseConference))
                ) && 
                (
                    this.GameId == input.GameId ||
                    (this.GameId != null &&
                    this.GameId.Equals(input.GameId))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.DriveNumber == input.DriveNumber ||
                    (this.DriveNumber != null &&
                    this.DriveNumber.Equals(input.DriveNumber))
                ) && 
                (
                    this.Scoring == input.Scoring ||
                    (this.Scoring != null &&
                    this.Scoring.Equals(input.Scoring))
                ) && 
                (
                    this.StartPeriod == input.StartPeriod ||
                    (this.StartPeriod != null &&
                    this.StartPeriod.Equals(input.StartPeriod))
                ) && 
                (
                    this.StartYardline == input.StartYardline ||
                    (this.StartYardline != null &&
                    this.StartYardline.Equals(input.StartYardline))
                ) && 
                (
                    this.StartYardsToGoal == input.StartYardsToGoal ||
                    (this.StartYardsToGoal != null &&
                    this.StartYardsToGoal.Equals(input.StartYardsToGoal))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndPeriod == input.EndPeriod ||
                    (this.EndPeriod != null &&
                    this.EndPeriod.Equals(input.EndPeriod))
                ) && 
                (
                    this.EndYardline == input.EndYardline ||
                    (this.EndYardline != null &&
                    this.EndYardline.Equals(input.EndYardline))
                ) && 
                (
                    this.EndYardsToGoal == input.EndYardsToGoal ||
                    (this.EndYardsToGoal != null &&
                    this.EndYardsToGoal.Equals(input.EndYardsToGoal))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.Plays == input.Plays ||
                    (this.Plays != null &&
                    this.Plays.Equals(input.Plays))
                ) && 
                (
                    this.Yards == input.Yards ||
                    (this.Yards != null &&
                    this.Yards.Equals(input.Yards))
                ) && 
                (
                    this.DriveResult == input.DriveResult ||
                    (this.DriveResult != null &&
                    this.DriveResult.Equals(input.DriveResult))
                ) && 
                (
                    this.IsHomeOffense == input.IsHomeOffense ||
                    (this.IsHomeOffense != null &&
                    this.IsHomeOffense.Equals(input.IsHomeOffense))
                ) && 
                (
                    this.StartOffenseScore == input.StartOffenseScore ||
                    (this.StartOffenseScore != null &&
                    this.StartOffenseScore.Equals(input.StartOffenseScore))
                ) && 
                (
                    this.StartDefenseScore == input.StartDefenseScore ||
                    (this.StartDefenseScore != null &&
                    this.StartDefenseScore.Equals(input.StartDefenseScore))
                ) && 
                (
                    this.EndOffenseScore == input.EndOffenseScore ||
                    (this.EndOffenseScore != null &&
                    this.EndOffenseScore.Equals(input.EndOffenseScore))
                ) && 
                (
                    this.EndDefenseScore == input.EndDefenseScore ||
                    (this.EndDefenseScore != null &&
                    this.EndDefenseScore.Equals(input.EndDefenseScore))
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
                if (this.Offense != null)
                    hashCode = hashCode * 59 + this.Offense.GetHashCode();
                if (this.OffenseConference != null)
                    hashCode = hashCode * 59 + this.OffenseConference.GetHashCode();
                if (this.Defense != null)
                    hashCode = hashCode * 59 + this.Defense.GetHashCode();
                if (this.DefenseConference != null)
                    hashCode = hashCode * 59 + this.DefenseConference.GetHashCode();
                if (this.GameId != null)
                    hashCode = hashCode * 59 + this.GameId.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.DriveNumber != null)
                    hashCode = hashCode * 59 + this.DriveNumber.GetHashCode();
                if (this.Scoring != null)
                    hashCode = hashCode * 59 + this.Scoring.GetHashCode();
                if (this.StartPeriod != null)
                    hashCode = hashCode * 59 + this.StartPeriod.GetHashCode();
                if (this.StartYardline != null)
                    hashCode = hashCode * 59 + this.StartYardline.GetHashCode();
                if (this.StartYardsToGoal != null)
                    hashCode = hashCode * 59 + this.StartYardsToGoal.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndPeriod != null)
                    hashCode = hashCode * 59 + this.EndPeriod.GetHashCode();
                if (this.EndYardline != null)
                    hashCode = hashCode * 59 + this.EndYardline.GetHashCode();
                if (this.EndYardsToGoal != null)
                    hashCode = hashCode * 59 + this.EndYardsToGoal.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Plays != null)
                    hashCode = hashCode * 59 + this.Plays.GetHashCode();
                if (this.Yards != null)
                    hashCode = hashCode * 59 + this.Yards.GetHashCode();
                if (this.DriveResult != null)
                    hashCode = hashCode * 59 + this.DriveResult.GetHashCode();
                if (this.IsHomeOffense != null)
                    hashCode = hashCode * 59 + this.IsHomeOffense.GetHashCode();
                if (this.StartOffenseScore != null)
                    hashCode = hashCode * 59 + this.StartOffenseScore.GetHashCode();
                if (this.StartDefenseScore != null)
                    hashCode = hashCode * 59 + this.StartDefenseScore.GetHashCode();
                if (this.EndOffenseScore != null)
                    hashCode = hashCode * 59 + this.EndOffenseScore.GetHashCode();
                if (this.EndDefenseScore != null)
                    hashCode = hashCode * 59 + this.EndDefenseScore.GetHashCode();
                return hashCode;
            }
        }
    }

}
