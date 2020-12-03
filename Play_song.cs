
using UnityEngine;

public class Play_song : MonoBehaviour
{
    new public AudioSource sound;
    private bool isPlaying;

    public void PlaySound()
    {
        if (isPlaying)
        {
            sound.Stop();
            isPlaying = false;
        }
        else
        {
            sound.Play();
            isPlaying = true;
        }
    
    }

}
