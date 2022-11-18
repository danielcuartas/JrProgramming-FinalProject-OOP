using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    [SerializeField] float jumpForce;
    Rigidbody rb;
    AudioSource audioController;
    [SerializeField] protected AudioClip clip;

    [SerializeField] string Name;


    // POLYMORPHISM
    public virtual void MakeSound()
    {
        Debug.Log("Playing crickets");
        audioController = GetComponent<AudioSource>();
        audioController.PlayOneShot(clip);
    }

    // POLYMORPHISM
    public virtual void Jump()
    {
        Debug.Log("jumping like a regular Animal");
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
