using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandlebarAndWheelSteering : MonoBehaviour
{
    public Animator handlebarAndWheelAnimator;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        handlebarAndWheelAnimator.SetFloat("rotation", GetComponent<Balancing>().currentAngle);
    }
}
