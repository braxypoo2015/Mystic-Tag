using UnityEngine;
using System.Collections.Generic;

public class MysticTagGame : MonoBehaviour
{
    public List<string> players = new List<string>();

    public string taggerId;
    public bool roundActive;

    public void StartRound(string firstTagger)
    {
        taggerId = firstTagger;
        roundActive = true;
        Debug.Log("Mystic Tag round started!");
    }

    public void TagPlayer(string playerId)
    {
        if (!roundActive) return;
        if (!players.Contains(playerId)) return;

        taggerId = playerId;
        Debug.Log(playerId + " is now the tagger!");
    }

    public void EndRound()
    {
        roundActive = false;
        Debug.Log("Mystic Tag round ended!");
    }
}
