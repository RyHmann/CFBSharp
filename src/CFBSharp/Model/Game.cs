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
    /// Game
    /// </summary>
    [DataContract]
    public partial class Game :  IEquatable<Game>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Game" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="season">season.</param>
        /// <param name="week">week.</param>
        /// <param name="seasonType">seasonType.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="startTimeTbd">startTimeTbd.</param>
        /// <param name="neutralSite">neutralSite.</param>
        /// <param name="conferenceGame">conferenceGame.</param>
        /// <param name="attendance">attendance.</param>
        /// <param name="venueId">venueId.</param>
        /// <param name="venue">venue.</param>
        /// <param name="homeId">homeId.</param>
        /// <param name="homeTeam">homeTeam.</param>
        /// <param name="homeConference">homeConference.</param>
        /// <param name="homePoints">homePoints.</param>
        /// <param name="homeLineScores">homeLineScores.</param>
        /// <param name="homePostWinProb">homePostWinProb.</param>
        /// <param name="awayId">awayId.</param>
        /// <param name="awayTeam">awayTeam.</param>
        /// <param name="awayConference">awayConference.</param>
        /// <param name="awayPoints">awayPoints.</param>
        /// <param name="awayLineScores">awayLineScores.</param>
        /// <param name="awayPostWinProb">awayPostWinProb.</param>
        /// <param name="excitementIndex">excitementIndex.</param>
        public Game(int? id = default(int?), int? season = default(int?), int? week = default(int?), string seasonType = default(string), string startDate = default(string), bool? startTimeTbd = default(bool?), bool? neutralSite = default(bool?), bool? conferenceGame = default(bool?), int? attendance = default(int?), int? venueId = default(int?), string venue = default(string), int? homeId = default(int?), string homeTeam = default(string), string homeConference = default(string), int? homePoints = default(int?), List<int?> homeLineScores = default(List<int?>), decimal? homePostWinProb = default(decimal?), int? awayId = default(int?), string awayTeam = default(string), string awayConference = default(string), int? awayPoints = default(int?), List<int?> awayLineScores = default(List<int?>), decimal? awayPostWinProb = default(decimal?), decimal? excitementIndex = default(decimal?))
        {
            this.Id = id;
            this.Season = season;
            this.Week = week;
            this.SeasonType = seasonType;
            this.StartDate = startDate;
            this.StartTimeTbd = startTimeTbd;
            this.NeutralSite = neutralSite;
            this.ConferenceGame = conferenceGame;
            this.Attendance = attendance;
            this.VenueId = venueId;
            this.Venue = venue;
            this.HomeId = homeId;
            this.HomeTeam = homeTeam;
            this.HomeConference = homeConference;
            this.HomePoints = homePoints;
            this.HomeLineScores = homeLineScores;
            this.HomePostWinProb = homePostWinProb;
            this.AwayId = awayId;
            this.AwayTeam = awayTeam;
            this.AwayConference = awayConference;
            this.AwayPoints = awayPoints;
            this.AwayLineScores = awayLineScores;
            this.AwayPostWinProb = awayPostWinProb;
            this.ExcitementIndex = excitementIndex;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Season
        /// </summary>
        [DataMember(Name="season", EmitDefaultValue=false)]
        public int? Season { get; set; }

        /// <summary>
        /// Gets or Sets Week
        /// </summary>
        [DataMember(Name="week", EmitDefaultValue=false)]
        public int? Week { get; set; }

        /// <summary>
        /// Gets or Sets SeasonType
        /// </summary>
        [DataMember(Name="season_type", EmitDefaultValue=false)]
        public string SeasonType { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="start_date", EmitDefaultValue=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// Gets or Sets StartTimeTbd
        /// </summary>
        [DataMember(Name="start_time_tbd", EmitDefaultValue=false)]
        public bool? StartTimeTbd { get; set; }

        /// <summary>
        /// Gets or Sets NeutralSite
        /// </summary>
        [DataMember(Name="neutral_site", EmitDefaultValue=false)]
        public bool? NeutralSite { get; set; }

        /// <summary>
        /// Gets or Sets ConferenceGame
        /// </summary>
        [DataMember(Name="conference_game", EmitDefaultValue=false)]
        public bool? ConferenceGame { get; set; }

        /// <summary>
        /// Gets or Sets Attendance
        /// </summary>
        [DataMember(Name="attendance", EmitDefaultValue=false)]
        public int? Attendance { get; set; }

        /// <summary>
        /// Gets or Sets VenueId
        /// </summary>
        [DataMember(Name="venue_id", EmitDefaultValue=false)]
        public int? VenueId { get; set; }

        /// <summary>
        /// Gets or Sets Venue
        /// </summary>
        [DataMember(Name="venue", EmitDefaultValue=false)]
        public string Venue { get; set; }

        /// <summary>
        /// Gets or Sets HomeId
        /// </summary>
        [DataMember(Name="home_id", EmitDefaultValue=false)]
        public int? HomeId { get; set; }

        /// <summary>
        /// Gets or Sets HomeTeam
        /// </summary>
        [DataMember(Name="home_team", EmitDefaultValue=false)]
        public string HomeTeam { get; set; }

        /// <summary>
        /// Gets or Sets HomeConference
        /// </summary>
        [DataMember(Name="home_conference", EmitDefaultValue=false)]
        public string HomeConference { get; set; }

        /// <summary>
        /// Gets or Sets HomePoints
        /// </summary>
        [DataMember(Name="home_points", EmitDefaultValue=false)]
        public int? HomePoints { get; set; }

        /// <summary>
        /// Gets or Sets HomeLineScores
        /// </summary>
        [DataMember(Name="home_line_scores", EmitDefaultValue=false)]
        public List<int?> HomeLineScores { get; set; }

        /// <summary>
        /// Gets or Sets HomePostWinProb
        /// </summary>
        [DataMember(Name="home_post_win_prob", EmitDefaultValue=false)]
        public decimal? HomePostWinProb { get; set; }

        /// <summary>
        /// Gets or Sets AwayId
        /// </summary>
        [DataMember(Name="away_id", EmitDefaultValue=false)]
        public int? AwayId { get; set; }

        /// <summary>
        /// Gets or Sets AwayTeam
        /// </summary>
        [DataMember(Name="away_team", EmitDefaultValue=false)]
        public string AwayTeam { get; set; }

        /// <summary>
        /// Gets or Sets AwayConference
        /// </summary>
        [DataMember(Name="away_conference", EmitDefaultValue=false)]
        public string AwayConference { get; set; }

        /// <summary>
        /// Gets or Sets AwayPoints
        /// </summary>
        [DataMember(Name="away_points", EmitDefaultValue=false)]
        public int? AwayPoints { get; set; }

        /// <summary>
        /// Gets or Sets AwayLineScores
        /// </summary>
        [DataMember(Name="away_line_scores", EmitDefaultValue=false)]
        public List<int?> AwayLineScores { get; set; }

        /// <summary>
        /// Gets or Sets AwayPostWinProb
        /// </summary>
        [DataMember(Name="away_post_win_prob", EmitDefaultValue=false)]
        public decimal? AwayPostWinProb { get; set; }

        /// <summary>
        /// Gets or Sets ExcitementIndex
        /// </summary>
        [DataMember(Name="excitement_index", EmitDefaultValue=false)]
        public decimal? ExcitementIndex { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Game {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  Week: ").Append(Week).Append("\n");
            sb.Append("  SeasonType: ").Append(SeasonType).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  StartTimeTbd: ").Append(StartTimeTbd).Append("\n");
            sb.Append("  NeutralSite: ").Append(NeutralSite).Append("\n");
            sb.Append("  ConferenceGame: ").Append(ConferenceGame).Append("\n");
            sb.Append("  Attendance: ").Append(Attendance).Append("\n");
            sb.Append("  VenueId: ").Append(VenueId).Append("\n");
            sb.Append("  Venue: ").Append(Venue).Append("\n");
            sb.Append("  HomeId: ").Append(HomeId).Append("\n");
            sb.Append("  HomeTeam: ").Append(HomeTeam).Append("\n");
            sb.Append("  HomeConference: ").Append(HomeConference).Append("\n");
            sb.Append("  HomePoints: ").Append(HomePoints).Append("\n");
            sb.Append("  HomeLineScores: ").Append(HomeLineScores).Append("\n");
            sb.Append("  HomePostWinProb: ").Append(HomePostWinProb).Append("\n");
            sb.Append("  AwayId: ").Append(AwayId).Append("\n");
            sb.Append("  AwayTeam: ").Append(AwayTeam).Append("\n");
            sb.Append("  AwayConference: ").Append(AwayConference).Append("\n");
            sb.Append("  AwayPoints: ").Append(AwayPoints).Append("\n");
            sb.Append("  AwayLineScores: ").Append(AwayLineScores).Append("\n");
            sb.Append("  AwayPostWinProb: ").Append(AwayPostWinProb).Append("\n");
            sb.Append("  ExcitementIndex: ").Append(ExcitementIndex).Append("\n");
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
            return this.Equals(input as Game);
        }

        /// <summary>
        /// Returns true if Game instances are equal
        /// </summary>
        /// <param name="input">Instance of Game to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Game input)
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
                    this.Season == input.Season ||
                    (this.Season != null &&
                    this.Season.Equals(input.Season))
                ) && 
                (
                    this.Week == input.Week ||
                    (this.Week != null &&
                    this.Week.Equals(input.Week))
                ) && 
                (
                    this.SeasonType == input.SeasonType ||
                    (this.SeasonType != null &&
                    this.SeasonType.Equals(input.SeasonType))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.StartTimeTbd == input.StartTimeTbd ||
                    (this.StartTimeTbd != null &&
                    this.StartTimeTbd.Equals(input.StartTimeTbd))
                ) && 
                (
                    this.NeutralSite == input.NeutralSite ||
                    (this.NeutralSite != null &&
                    this.NeutralSite.Equals(input.NeutralSite))
                ) && 
                (
                    this.ConferenceGame == input.ConferenceGame ||
                    (this.ConferenceGame != null &&
                    this.ConferenceGame.Equals(input.ConferenceGame))
                ) && 
                (
                    this.Attendance == input.Attendance ||
                    (this.Attendance != null &&
                    this.Attendance.Equals(input.Attendance))
                ) && 
                (
                    this.VenueId == input.VenueId ||
                    (this.VenueId != null &&
                    this.VenueId.Equals(input.VenueId))
                ) && 
                (
                    this.Venue == input.Venue ||
                    (this.Venue != null &&
                    this.Venue.Equals(input.Venue))
                ) && 
                (
                    this.HomeId == input.HomeId ||
                    (this.HomeId != null &&
                    this.HomeId.Equals(input.HomeId))
                ) && 
                (
                    this.HomeTeam == input.HomeTeam ||
                    (this.HomeTeam != null &&
                    this.HomeTeam.Equals(input.HomeTeam))
                ) && 
                (
                    this.HomeConference == input.HomeConference ||
                    (this.HomeConference != null &&
                    this.HomeConference.Equals(input.HomeConference))
                ) && 
                (
                    this.HomePoints == input.HomePoints ||
                    (this.HomePoints != null &&
                    this.HomePoints.Equals(input.HomePoints))
                ) && 
                (
                    this.HomeLineScores == input.HomeLineScores ||
                    this.HomeLineScores != null &&
                    this.HomeLineScores.SequenceEqual(input.HomeLineScores)
                ) && 
                (
                    this.HomePostWinProb == input.HomePostWinProb ||
                    (this.HomePostWinProb != null &&
                    this.HomePostWinProb.Equals(input.HomePostWinProb))
                ) && 
                (
                    this.AwayId == input.AwayId ||
                    (this.AwayId != null &&
                    this.AwayId.Equals(input.AwayId))
                ) && 
                (
                    this.AwayTeam == input.AwayTeam ||
                    (this.AwayTeam != null &&
                    this.AwayTeam.Equals(input.AwayTeam))
                ) && 
                (
                    this.AwayConference == input.AwayConference ||
                    (this.AwayConference != null &&
                    this.AwayConference.Equals(input.AwayConference))
                ) && 
                (
                    this.AwayPoints == input.AwayPoints ||
                    (this.AwayPoints != null &&
                    this.AwayPoints.Equals(input.AwayPoints))
                ) && 
                (
                    this.AwayLineScores == input.AwayLineScores ||
                    this.AwayLineScores != null &&
                    this.AwayLineScores.SequenceEqual(input.AwayLineScores)
                ) && 
                (
                    this.AwayPostWinProb == input.AwayPostWinProb ||
                    (this.AwayPostWinProb != null &&
                    this.AwayPostWinProb.Equals(input.AwayPostWinProb))
                ) && 
                (
                    this.ExcitementIndex == input.ExcitementIndex ||
                    (this.ExcitementIndex != null &&
                    this.ExcitementIndex.Equals(input.ExcitementIndex))
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
                if (this.Season != null)
                    hashCode = hashCode * 59 + this.Season.GetHashCode();
                if (this.Week != null)
                    hashCode = hashCode * 59 + this.Week.GetHashCode();
                if (this.SeasonType != null)
                    hashCode = hashCode * 59 + this.SeasonType.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.StartTimeTbd != null)
                    hashCode = hashCode * 59 + this.StartTimeTbd.GetHashCode();
                if (this.NeutralSite != null)
                    hashCode = hashCode * 59 + this.NeutralSite.GetHashCode();
                if (this.ConferenceGame != null)
                    hashCode = hashCode * 59 + this.ConferenceGame.GetHashCode();
                if (this.Attendance != null)
                    hashCode = hashCode * 59 + this.Attendance.GetHashCode();
                if (this.VenueId != null)
                    hashCode = hashCode * 59 + this.VenueId.GetHashCode();
                if (this.Venue != null)
                    hashCode = hashCode * 59 + this.Venue.GetHashCode();
                if (this.HomeId != null)
                    hashCode = hashCode * 59 + this.HomeId.GetHashCode();
                if (this.HomeTeam != null)
                    hashCode = hashCode * 59 + this.HomeTeam.GetHashCode();
                if (this.HomeConference != null)
                    hashCode = hashCode * 59 + this.HomeConference.GetHashCode();
                if (this.HomePoints != null)
                    hashCode = hashCode * 59 + this.HomePoints.GetHashCode();
                if (this.HomeLineScores != null)
                    hashCode = hashCode * 59 + this.HomeLineScores.GetHashCode();
                if (this.HomePostWinProb != null)
                    hashCode = hashCode * 59 + this.HomePostWinProb.GetHashCode();
                if (this.AwayId != null)
                    hashCode = hashCode * 59 + this.AwayId.GetHashCode();
                if (this.AwayTeam != null)
                    hashCode = hashCode * 59 + this.AwayTeam.GetHashCode();
                if (this.AwayConference != null)
                    hashCode = hashCode * 59 + this.AwayConference.GetHashCode();
                if (this.AwayPoints != null)
                    hashCode = hashCode * 59 + this.AwayPoints.GetHashCode();
                if (this.AwayLineScores != null)
                    hashCode = hashCode * 59 + this.AwayLineScores.GetHashCode();
                if (this.AwayPostWinProb != null)
                    hashCode = hashCode * 59 + this.AwayPostWinProb.GetHashCode();
                if (this.ExcitementIndex != null)
                    hashCode = hashCode * 59 + this.ExcitementIndex.GetHashCode();
                return hashCode;
            }
        }
    }

}
