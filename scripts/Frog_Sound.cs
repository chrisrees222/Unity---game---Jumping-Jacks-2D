using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frog_Sound : MonoBehaviour
{
    public static AudioClip FrogJump;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        FrogJump = Resources.Load<AudioClip>("Frog_Croak_2");
        audioSrc = GetComponent<AudioSource>();
    }

    public static void PlayCroak()
    {
        audioSrc.PlayOneShot(FrogJump);
    }
}
