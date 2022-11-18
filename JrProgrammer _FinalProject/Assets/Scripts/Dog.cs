using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Dog : Animal
{
    AudioSource audioController;
    // POLYMORPHISM
    public override void MakeSound()
    {
        Debug.Log("Woof");
        audioController = GetComponent<AudioSource>();
        audioController.PlayOneShot(clip);
    }
}
