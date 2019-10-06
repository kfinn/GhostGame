using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeIntrinsicRebalancing : MonoBehaviour
{
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var balancing = GetComponent<Balancing>();
        balancing.ApplyForce(-balancing.currentAngle * Time.deltaTime * 3);
    }
}
