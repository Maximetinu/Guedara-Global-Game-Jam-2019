using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class StepSounds : MonoBehaviour
{
    public AudioClip step;
    AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    public void PlayStep()
    {
        source.PlayOneShot(step);
    }
}
