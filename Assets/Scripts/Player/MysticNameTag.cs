using UnityEngine;

public class MysticNameTag : MonoBehaviour
{
    [Header("Name Settings")]
    public string playerName = "Mystic Player";
    public Transform head;
    public Transform nameTag;

    [Header("Position")]
    public Vector3 offset = new Vector3(0f, 0.35f, 0f);

    void LateUpdate()
    {
        if (head == null || nameTag == null) return;

        nameTag.position = head.position + offset;

        if (Camera.main != null)
        {
            nameTag.rotation = Quaternion.LookRotation(
                nameTag.position - Camera.main.transform.position
            );
        }
    }

    public void SetName(string newName)
    {
        playerName = newName;
    }
}
