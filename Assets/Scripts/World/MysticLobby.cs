using UnityEngine;

public class MysticLobby : MonoBehaviour
{
    [Header("Lobby Settings")]
    public string lobbyName = "Mystic Plaza";
    public int maxPlayers = 10;

    [Header("Lobby State")]
    public bool lobbyActive;

    void Start()
    {
        lobbyActive = true;
        Debug.Log("Welcome to " + lobbyName + "!");
        Debug.Log("Maximum players: " + maxPlayers);
    }

    public void JoinLobby(string playerName)
    {
        Debug.Log(playerName + " joined " + lobbyName);
    }

    public void LeaveLobby(string playerName)
    {
        Debug.Log(playerName + " left " + lobbyName);
    }
}
