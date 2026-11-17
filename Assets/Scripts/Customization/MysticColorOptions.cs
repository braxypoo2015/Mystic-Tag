using UnityEngine;

public class MysticColorOptions : MonoBehaviour
{
    public Renderer playerRenderer;

    public void SetColor(float r, float g, float b)
    {
        if (playerRenderer == null) return;

        Color color = new Color(r, g, b);

        if (playerRenderer.material.HasProperty("_BaseColor"))
            playerRenderer.material.SetColor("_BaseColor", color);
        else
            playerRenderer.material.color = color;
    }

    public void SetOrange()
    {
        SetColor(1f, 0.4f, 0f);
    }

    public void SetPink()
    {
        SetColor(1f, 0.2f, 0.6f);
    }

    public void SetYellow()
    {
        SetColor(1f, 0.9f, 0f);
    }

    public void SetCyan()
    {
        SetColor(0f, 0.9f, 1f);
    }

    public void SetBlack()
    {
        SetColor(0.05f, 0.05f, 0.05f);
    }
}
