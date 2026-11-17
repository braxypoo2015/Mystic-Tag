using UnityEngine;

public class MysticPlayerSetup : MonoBehaviour
{
    [Header("Character Model")]
    public GameObject playerModel;

    [Header("Player Components")]
    public MysticPlayer player;
    public MysticVRPlayer vrPlayer;
    public MysticCustomization customization;

    void Awake()
    {
        if (playerModel != null)
            playerModel.SetActive(true);

        if (player == null)
            player = GetComponent<MysticPlayer>();

        if (vrPlayer == null)
            vrPlayer = GetComponent<MysticVRPlayer>();

        if (customization == null)
            customization = GetComponent<MysticCustomization>();

        Debug.Log("Mystic Tag player setup loaded!");
    }
}
