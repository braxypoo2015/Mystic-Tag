using UnityEngine;

public class MysticPlayer : MonoBehaviour
{
    [Header("Player Settings")]
    public float movementSpeed = 4f;
    public float jumpForce = 5f;

    [Header("Player State")]
    public string playerName = "Mystic Player";
    public int playerLevel = 1;

    public void SetPlayerName(string newName)
    {
        playerName = newName;
    }

    public void SetPlayerLevel(int newLevel)
    {
        playerLevel = Mathf.Max(1, newLevel);
    }
}
