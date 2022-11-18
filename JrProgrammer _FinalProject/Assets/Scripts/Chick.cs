using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Chick : Animal
{
    AudioSource audioController;
    // POLYMORPHISM
    public override void MakeSound()
    {
        Debug.Log("piu");
        audioController = GetComponent<AudioSource>();
        audioController.PlayOneShot(clip);
    }
}
