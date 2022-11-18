using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Cat : Animal
{
    AudioSource audioController;

    // POLYMORPHISM
    public override void MakeSound()
    {
        Debug.Log("Meow");
        audioController = GetComponent<AudioSource>();
        audioController.PlayOneShot(clip);
    }

}
