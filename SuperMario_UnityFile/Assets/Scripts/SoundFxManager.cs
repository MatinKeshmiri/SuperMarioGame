using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFxManager : MonoBehaviour
{
    AudioSource sfxPlayer;
    // Start is called before the first frame update
    private void Start()
    {
        sfxPlayer = gameObject.GetComponent<AudioSource>();
    }
    public void PlaySoundFX(AudioClip sfx)
    {
        sfxPlayer.PlayOneShot(sfx);
    }


}
