# CFBSharp.Api.GamesApi

All URIs are relative to *https://api.collegefootballdata.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAdvancedBoxScore**](GamesApi.md#getadvancedboxscore) | **GET** /game/box/advanced | Get advanced box score
[**GetGames**](GamesApi.md#getgames) | **GET** /games | Get game information
[**GetPlayerGameStats**](GamesApi.md#getplayergamestats) | **GET** /games/players | Get player statistics by game
[**GetTeamGameStats**](GamesApi.md#getteamgamestats) | **GET** /games/teams | Get team statistics by game
[**GetTeamRecords**](GamesApi.md#getteamrecords) | **GET** /records | Get records by year


<a name="getadvancedboxscore"></a>
# **GetAdvancedBoxScore**
> ICollection<BoxScore> GetAdvancedBoxScore (int? gameId)

Get advanced box score

Advanced box score

### Example
```csharp
using System;
using System.Diagnostics;
using CFBSharp.Api;
using CFBSharp.Client;
using CFBSharp.Model;

namespace Example
{
    public class GetAdvancedBoxScoreExample
    {
        public void main()
        {
            var apiInstance = new GamesApi();
            var gameId = 56;  // int? | Game id parameters

            try
            {
                // Get advanced box score
                ICollection&lt;BoxScore&gt; result = apiInstance.GetAdvancedBoxScore(gameId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamesApi.GetAdvancedBoxScore: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gameId** | **int?**| Game id parameters | 

### Return type

[**ICollection<BoxScore>**](BoxScore.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgames"></a>
# **GetGames**
> ICollection<Game> GetGames (int? year, int? week = null, string seasonType = null, string team = null, string home = null, string away = null, string conference = null, int? id = null)

Get game information

Game results

### Example
```csharp
using System;
using System.Diagnostics;
using CFBSharp.Api;
using CFBSharp.Client;
using CFBSharp.Model;

namespace Example
{
    public class GetGamesExample
    {
        public void main()
        {
            var apiInstance = new GamesApi();
            var year = 56;  // int? | Year/season filter for games
            var week = 56;  // int? | Week filter (optional) 
            var seasonType = seasonType_example;  // string | Season type filter (regular or postseason) (optional)  (default to regular)
            var team = team_example;  // string | Team (optional) 
            var home = home_example;  // string | Home team filter (optional) 
            var away = away_example;  // string | Away team filter (optional) 
            var conference = conference_example;  // string | Conference abbreviation filter (optional) 
            var id = 56;  // int? | id filter for querying a single game (optional) 

            try
            {
                // Get game information
                ICollection&lt;Game&gt; result = apiInstance.GetGames(year, week, seasonType, team, home, away, conference, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamesApi.GetGames: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **year** | **int?**| Year/season filter for games | 
 **week** | **int?**| Week filter | [optional] 
 **seasonType** | **string**| Season type filter (regular or postseason) | [optional] [default to regular]
 **team** | **string**| Team | [optional] 
 **home** | **string**| Home team filter | [optional] 
 **away** | **string**| Away team filter | [optional] 
 **conference** | **string**| Conference abbreviation filter | [optional] 
 **id** | **int?**| id filter for querying a single game | [optional] 

### Return type

[**ICollection<Game>**](Game.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getplayergamestats"></a>
# **GetPlayerGameStats**
> ICollection<PlayerGame> GetPlayerGameStats (int? year, int? week = null, string seasonType = null, string team = null, string conference = null, string category = null, int? gameId = null)

Get player statistics by game

Player game stats

### Example
```csharp
using System;
using System.Diagnostics;
using CFBSharp.Api;
using CFBSharp.Client;
using CFBSharp.Model;

namespace Example
{
    public class GetPlayerGameStatsExample
    {
        public void main()
        {
            var apiInstance = new GamesApi();
            var year = 56;  // int? | Year/season filter for games
            var week = 56;  // int? | Week filter (optional) 
            var seasonType = seasonType_example;  // string | Season type filter (regular or postseason) (optional)  (default to regular)
            var team = team_example;  // string | Team filter (optional) 
            var conference = conference_example;  // string | Conference abbreviation filter (optional) 
            var category = category_example;  // string | Category filter (e.g defensive) (optional) 
            var gameId = 56;  // int? | Game id filter (optional) 

            try
            {
                // Get player statistics by game
                ICollection&lt;PlayerGame&gt; result = apiInstance.GetPlayerGameStats(year, week, seasonType, team, conference, category, gameId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamesApi.GetPlayerGameStats: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **year** | **int?**| Year/season filter for games | 
 **week** | **int?**| Week filter | [optional] 
 **seasonType** | **string**| Season type filter (regular or postseason) | [optional] [default to regular]
 **team** | **string**| Team filter | [optional] 
 **conference** | **string**| Conference abbreviation filter | [optional] 
 **category** | **string**| Category filter (e.g defensive) | [optional] 
 **gameId** | **int?**| Game id filter | [optional] 

### Return type

[**ICollection<PlayerGame>**](PlayerGame.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getteamgamestats"></a>
# **GetTeamGameStats**
> ICollection<TeamGame> GetTeamGameStats (int? year, int? week = null, string seasonType = null, string team = null, string conference = null, int? gameId = null)

Get team statistics by game

Team game stats

### Example
```csharp
using System;
using System.Diagnostics;
using CFBSharp.Api;
using CFBSharp.Client;
using CFBSharp.Model;

namespace Example
{
    public class GetTeamGameStatsExample
    {
        public void main()
        {
            var apiInstance = new GamesApi();
            var year = 56;  // int? | Year/season filter for games
            var week = 56;  // int? | Week filter (optional) 
            var seasonType = seasonType_example;  // string | Season type filter (regular or postseason) (optional)  (default to regular)
            var team = team_example;  // string | Team filter (optional) 
            var conference = conference_example;  // string | Conference abbreviation filter (optional) 
            var gameId = 56;  // int? | Game id filter (optional) 

            try
            {
                // Get team statistics by game
                ICollection&lt;TeamGame&gt; result = apiInstance.GetTeamGameStats(year, week, seasonType, team, conference, gameId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamesApi.GetTeamGameStats: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **year** | **int?**| Year/season filter for games | 
 **week** | **int?**| Week filter | [optional] 
 **seasonType** | **string**| Season type filter (regular or postseason) | [optional] [default to regular]
 **team** | **string**| Team filter | [optional] 
 **conference** | **string**| Conference abbreviation filter | [optional] 
 **gameId** | **int?**| Game id filter | [optional] 

### Return type

[**ICollection<TeamGame>**](TeamGame.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getteamrecords"></a>
# **GetTeamRecords**
> ICollection<TeamRecord> GetTeamRecords (int? year = null, string team = null, string conference = null)

Get records by year

Team records by year

### Example
```csharp
using System;
using System.Diagnostics;
using CFBSharp.Api;
using CFBSharp.Client;
using CFBSharp.Model;

namespace Example
{
    public class GetTeamRecordsExample
    {
        public void main()
        {
            var apiInstance = new GamesApi();
            var year = 56;  // int? | Year filter (optional) 
            var team = team_example;  // string | Team filter (optional) 
            var conference = conference_example;  // string | Conference filter (optional) 

            try
            {
                // Get records by year
                ICollection&lt;TeamRecord&gt; result = apiInstance.GetTeamRecords(year, team, conference);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GamesApi.GetTeamRecords: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **year** | **int?**| Year filter | [optional] 
 **team** | **string**| Team filter | [optional] 
 **conference** | **string**| Conference filter | [optional] 

### Return type

[**ICollection<TeamRecord>**](TeamRecord.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
