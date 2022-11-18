using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public string selectedAnimal;

    // ABSTRACTION
    public void CatButton()
    {
        selectedAnimal = "Cat";

        Debug.Log("identified as Cat");
    }

    public void DogButton()
    {
        selectedAnimal = "Dog";
        Debug.Log("identified as Dog");
    }

    public void ChickButton()
    {
        selectedAnimal = "Chick";
        Debug.Log("identified as Chick");
    }

    // ABSTRACTION
    public void MakeSound()
    {
        switch (selectedAnimal)
        {
            case "Cat":
                Debug.Log("making cat sounds");
                GameObject.Find("Cat").GetComponent<Cat>().MakeSound();
                break;
            case "Dog":
                Debug.Log("making dog sounds");
                GameObject.Find("Dog").GetComponent<Dog>().MakeSound();
                break;
            case "Chick":
                Debug.Log("making chick sounds");
                GameObject.Find("Chick").GetComponent<Chick>().MakeSound();
                break;
            default:
                Debug.Log("making crickets sounds");
                GameObject.Find("Animals").GetComponent<Animal>().MakeSound();
                break;
        }   
                
    }
    // ABSTRACTION
    public void Jump()
    {
        switch (selectedAnimal)
        {
            case "Cat": 
                GameObject.Find("Cat").GetComponent<Cat>().Jump();
                break;

            case "Dog":
                GameObject.Find("Dog").GetComponent<Dog>().Jump();
                break;

            case "Chick":
                GameObject.Find("Chick").GetComponent<Chick>().Jump();
                break;
        }
    }
}
