using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{

    public AudioSource BGMusic;
    public AudioClip BGMClip;
    // Start is called before the first frame update
    void Start()
    {
        PlayBGM();
    }

    // a function that plays the BGM clip and loops it
    public void PlayBGM()
    {
        BGMusic.clip = BGMClip;
        BGMusic.loop = true;
        BGMusic.Play();
    }

}
