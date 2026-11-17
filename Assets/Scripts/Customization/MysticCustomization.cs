using UnityEngine;

public class MysticCustomization : MonoBehaviour
{
    public Renderer playerRenderer;

    public void SetPlayerColor(Color color)
    {
        if (playerRenderer == null) return;

        playerRenderer.material.color = color;
    }

    public void SetRed()
    {
        SetPlayerColor(Color.red);
    }

    public void SetBlue()
    {
        SetPlayerColor(Color.blue);
    }

    public void SetGreen()
    {
        SetPlayerColor(Color.green);
    }

    public void SetPurple()
    {
        SetPlayerColor(new Color(0.6f, 0.2f, 1f));
    }
}
