using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformBalanceTracking : MonoBehaviour
{
    public Transform target;
    void Start()
    {

    }

    void Update()
    {
        var dx = transform.position.x - target.transform.position.x;
        GetComponent<Balancing>().ApplyForce(dx * 20 * Time.deltaTime);
    }
}
