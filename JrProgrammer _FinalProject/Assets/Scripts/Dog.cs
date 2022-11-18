using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    AudioSource audioController;
    public override void MakeSound()
    {
        Debug.Log("Woof");
        audioController = GetComponent<AudioSource>();
        audioController.PlayOneShot(clip);
    }
}
