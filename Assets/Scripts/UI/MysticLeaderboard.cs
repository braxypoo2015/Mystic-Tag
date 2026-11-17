using UnityEngine;
using System.Collections.Generic;

[System.Serializable]
public class MysticLeaderboardEntry
{
    public string playerName;
    public int tagWins;
    public int roundsPlayed;
}

public class MysticLeaderboard : MonoBehaviour
{
    public List<MysticLeaderboardEntry> entries =
        new List<MysticLeaderboardEntry>();

    public void AddPlayer(string name)
    {
        if (entries.Exists(x => x.playerName == name))
            return;

        entries.Add(new MysticLeaderboardEntry
        {
            playerName = name,
            tagWins = 0,
            roundsPlayed = 0
        });
    }

    public void AddWin(string name)
    {
        MysticLeaderboardEntry entry =
            entries.Find(x => x.playerName == name);

        if (entry != null)
            entry.tagWins++;
    }

    public void AddRound(string name)
    {
        MysticLeaderboardEntry entry =
            entries.Find(x => x.playerName == name);

        if (entry != null)
            entry.roundsPlayed++;
    }
}
