using UnityEngine;

public class MysticNetworkPlayer : MonoBehaviour
{
    public string playerId;
    public string playerName = "Mystic Player";
    public int playerLevel = 1;

    public void SetPlayerData(string id, string name)
    {
        playerId = id;
        playerName = name;
    }
}
