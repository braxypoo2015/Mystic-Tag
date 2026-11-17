using UnityEngine;
using System.Collections.Generic;

public class MysticTagManager : MonoBehaviour
{
    public List<string> players = new List<string>();

    public string currentTagger;
    public bool roundActive;

    public float tagCooldown = 2f;
    private float nextTagTime;

    public void RegisterPlayer(string playerId)
    {
        if (!players.Contains(playerId))
            players.Add(playerId);
    }

    public void RemovePlayer(string playerId)
    {
        players.Remove(playerId);

        if (currentTagger == playerId)
            EndRound();
    }

    public void StartRound()
    {
        if (players.Count < 2)
        {
            Debug.Log("Need at least 2 players!");
            return;
        }

        currentTagger = players[Random.Range(0, players.Count)];
        roundActive = true;

        Debug.Log(currentTagger + " is IT!");
    }

    public void TagPlayer(string newTagger)
    {
        if (!roundActive) return;
        if (Time.time < nextTagTime) return;
        if (!players.Contains(newTagger)) return;

        currentTagger = newTagger;
        nextTagTime = Time.time + tagCooldown;

        Debug.Log(newTagger + " is now IT!");
    }

    public void EndRound()
    {
        roundActive = false;
        currentTagger = "";

        Debug.Log("Round ended!");
    }
}
