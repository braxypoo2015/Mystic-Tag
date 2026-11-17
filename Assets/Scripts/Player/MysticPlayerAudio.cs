using UnityEngine;

public class MysticPlayerAudio : MonoBehaviour
{
    public AudioSource audioSource;

    [Header("Sound Effects")]
    public AudioClip tagSound;
    public AudioClip taggedSound;
    public AudioClip joinSound;
    public AudioClip leaveSound;

    public void PlayTag()
    {
        Play(tagSound);
    }

    public void PlayTagged()
    {
        Play(taggedSound);
    }

    public void PlayJoin()
    {
        Play(joinSound);
    }

    public void PlayLeave()
    {
        Play(leaveSound);
    }

    private void Play(AudioClip clip)
    {
        if (audioSource == null || clip == null) return;

        audioSource.PlayOneShot(clip);
    }
}
