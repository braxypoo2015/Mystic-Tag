using UnityEngine;

public class MysticVRPlayer : MonoBehaviour
{
    [Header("VR Tracking")]
    public Transform head;
    public Transform leftHand;
    public Transform rightHand;

    [Header("Movement")]
    public float movementSpeed = 3f;

    private Vector3 lastHeadPosition;

    void Start()
    {
        if (head != null)
            lastHeadPosition = head.position;
    }

    void Update()
    {
        if (head == null) return;

        Vector3 movement = head.position - lastHeadPosition;
        movement.y = 0f;

        if (movement.magnitude > 0.5f)
            movement = Vector3.zero;

        transform.position += movement;

        lastHeadPosition = head.position;
    }
}
