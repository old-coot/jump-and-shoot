using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource Music;

    public void SetMusicEnabled(bool value){
        Music.enabled = value;
    }

    public void SetVolume(float value){
        AudioListener.volume = value;
    }
}
