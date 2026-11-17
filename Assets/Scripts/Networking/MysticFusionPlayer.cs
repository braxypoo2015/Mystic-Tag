using UnityEngine;

public class MysticFusionPlayer : MonoBehaviour
{
    [Header("Player Information")]
    public string playerId;
    public string playerName = "Mystic Player";

    [Header("Player State")]
    public bool isTagger;
    public int playerLevel = 1;

    public void SetPlayerName(string newName)
    {
        playerName = newName;
    }

    public void SetTagger(bool value)
    {
        isTagger = value;
    }

    public void SetLevel(int value)
    {
        playerLevel = Mathf.Max(1, value);
    }
}
