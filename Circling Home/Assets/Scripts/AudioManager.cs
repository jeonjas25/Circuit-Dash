using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource musicSource;
    public AudioSource SFXSource;

    public AudioClip background;
    public AudioClip melee;
    public AudioClip laser;
    public AudioClip lightningBolt;
    public AudioClip slash;
    public AudioClip jump;
    public AudioClip death;
    public AudioClip checkpoint;

    private void Start()
    {
        musicSource.clip = background;
        musicSource.loop = true;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}
