using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

class IPLMatch
{
    public int MatchId { get; set; }
    public string Team1 { get; set; }
    public string Team2 { get; set; }
    public Dictionary<string, int> Score { get; set; }
    public string Winner { get; set; }
    public string PlayerOfMatch { get; set; }
}

class Program
{
    static void Main()
    {
        try
        {
            // Process JSON File
            string jsonFilePath = "ipl_data.json";
            if (File.Exists(jsonFilePath))
            {
                string jsonContent = File.ReadAllText(jsonFilePath);
                List<IPLMatch> matches = JsonConvert.DeserializeObject<List<IPLMatch>>(jsonContent);

                if (matches != null && matches.Count > 0)
                {
                    Console.WriteLine("✅ JSON Data Loaded Successfully!");
                    ApplyCensorship(matches);

                    // Save Censored JSON
                    string censoredJson = JsonConvert.SerializeObject(matches, Formatting.Indented);
                    File.WriteAllText("ipl_data_censored.json", censoredJson);
                    Console.WriteLine("✅ Censored JSON Saved: ipl_data_censored.json");

                    // Save Censored CSV
                    SaveToCsv(matches, "ipl_data_censored.csv");
                }
                else
                {
                    Console.WriteLine("❌ Error: No valid match data found in JSON!");
                }
            }
            else
            {
                Console.WriteLine("❌ JSON file not found! Skipping JSON processing.");
            }

            // Process CSV File
            string csvFilePath = "ipl_data.csv";
            if (File.Exists(csvFilePath))
            {
                List<IPLMatch> csvMatches = ReadCsv(csvFilePath);
                if (csvMatches.Count > 0)
                {
                    Console.WriteLine("✅ CSV Data Loaded Successfully!");
                    ApplyCensorship(csvMatches);

                    // Save Censored CSV
                    SaveToCsv(csvMatches, "ipl_data_censored.csv");
                    Console.WriteLine("✅ Censored CSV Saved: ipl_data_censored.csv");
                }
                else
                {
                    Console.WriteLine("❌ Error: No valid match data found in CSV!");
                }
            }
            else
            {
                Console.WriteLine("❌ CSV file not found! Skipping CSV processing.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("⚠️ Error: " + ex.Message);
        }
    }

    static void ApplyCensorship(List<IPLMatch> matches)
    {
        foreach (var match in matches)
        {
            Console.WriteLine($"Processing Match {match.MatchId}: {match.Team1 ?? "UNKNOWN"} vs {match.Team2 ?? "UNKNOWN"}");

            match.Team1 = CensorTeamName(match.Team1);
            match.Team2 = CensorTeamName(match.Team2);
            match.Winner = CensorTeamName(match.Winner);
            match.PlayerOfMatch = "REDACTED";

            if (match.Score != null)
            {
                Dictionary<string, int> newScore = new Dictionary<string, int>();
                foreach (var entry in match.Score)
                {
                    string censoredTeam = CensorTeamName(entry.Key);
                    newScore[censoredTeam] = entry.Value;
                }
                match.Score = newScore;
            }
        }
    }

    static string CensorTeamName(string teamName)
    {
        if (string.IsNullOrWhiteSpace(teamName))
        {
            return "UNKNOWN ***";  // Default for null/missing values
        }

        string[] words = teamName.Split(' ');
        if (words.Length > 1)
        {
            words[1] = "***"; // Masking the second word
        }

        return string.Join(" ", words);
    }

    static void SaveToCsv(List<IPLMatch> matches, string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            // Write CSV Header
            writer.WriteLine("match_id,team1,team2,score_team1,score_team2,winner,player_of_match");

            // Write Match Data
            foreach (var match in matches)
            {
                int scoreTeam1 = match.Score?.ContainsKey(match.Team1) == true ? match.Score[match.Team1] : 0;
                int scoreTeam2 = match.Score?.ContainsKey(match.Team2) == true ? match.Score[match.Team2] : 0;

                writer.WriteLine($"{match.MatchId},{match.Team1},{match.Team2},{scoreTeam1},{scoreTeam2},{match.Winner},{match.PlayerOfMatch}");
            }
        }
    }

    static List<IPLMatch> ReadCsv(string filePath)
    {
        List<IPLMatch> matches = new List<IPLMatch>();
        string[] lines = File.ReadAllLines(filePath);

        if (lines.Length < 2)
        {
            Console.WriteLine("❌ CSV file is empty!");
            return matches;
        }

        for (int i = 1; i < lines.Length; i++)
        {
            string[] values = lines[i].Split(',');
            if (values.Length < 7) continue;

            matches.Add(new IPLMatch
            {
                MatchId = int.TryParse(values[0], out int matchId) ? matchId : 0,
                Team1 = values[1],
                Team2 = values[2],
                Score = new Dictionary<string, int>
                {
                    { values[1], int.TryParse(values[3], out int score1) ? score1 : 0 },
                    { values[2], int.TryParse(values[4], out int score2) ? score2 : 0 }
                },
                Winner = values[5],
                PlayerOfMatch = values[6]
            });
        }

        return matches;
    }
}
