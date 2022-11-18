using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Cat : Animal
{
    AudioSource audioController;
    public override void MakeSound()
    {
        Debug.Log("Meow");
        audioController = GetComponent<AudioSource>();
        audioController.PlayOneShot(clip);
    }

}
