using UnityEngine;

public class MysticVRTracking : MonoBehaviour
{
    [Header("VR Tracking References")]
    public Transform head;
    public Transform leftHand;
    public Transform rightHand;

    [Header("Player Body")]
    public Transform playerBody;

    void LateUpdate()
    {
        if (head == null) return;

        if (playerBody != null)
        {
            Vector3 bodyRotation = head.eulerAngles;
            playerBody.rotation = Quaternion.Euler(
                0f,
                bodyRotation.y,
                0f
            );
        }
    }
}
