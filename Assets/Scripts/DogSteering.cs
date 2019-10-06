using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogSteering : MonoBehaviour
{
    public Animator dogAnimator;

    void Start()
    {

    }


    void Update()
    {
        dogAnimator.SetFloat("velocity", GetComponent<Chasing>().velocity);
    }
}
