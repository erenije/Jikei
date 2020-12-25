using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sfx : MonoBehaviour
{
    private AudioSource audioSrc;
    public float sfxVolume = 1f;
    // Start is called before the first frame update
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        audioSrc.volume = sfxVolume;
    }
    public void setVolume(float vol)
    {
        sfxVolume = vol;
    }
}

