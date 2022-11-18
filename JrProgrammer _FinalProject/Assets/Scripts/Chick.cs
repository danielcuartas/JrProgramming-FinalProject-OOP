using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chick : Animal
{
    AudioSource audioController;
    public override void MakeSound()
    {
        Debug.Log("piu");
        audioController = GetComponent<AudioSource>();
        audioController.PlayOneShot(clip);
    }
}
