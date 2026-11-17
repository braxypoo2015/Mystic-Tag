using UnityEngine;

public class MysticSettings : MonoBehaviour
{
    [Range(0f, 1f)]
    public float musicVolume = 0.7f;

    [Range(0f, 1f)]
    public float soundVolume = 1f;

    public float movementSpeed = 3f;

    public void SetMusicVolume(float value)
    {
        musicVolume = Mathf.Clamp01(value);
    }

    public void SetSoundVolume(float value)
    {
        soundVolume = Mathf.Clamp01(value);
    }

    public void SetMovementSpeed(float value)
    {
        movementSpeed = Mathf.Clamp(value, 1f, 8f);
    }

    public void ApplySettings()
    {
        AudioListener.volume = soundVolume;
        Debug.Log("Mystic Tag settings applied!");
    }
}
