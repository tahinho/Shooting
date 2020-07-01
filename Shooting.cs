using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField]

    private AudioClip[] clips;
   

    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Shoot()
    {
        AudioClip clip = GetRandomClip();
        audioSource.PlayOneShot(clip);
    }

    private AudioClip GetRandomClip()
    {
        return clips[UnityEngine.Random.Range(0, clips.Length)];
    }
}
