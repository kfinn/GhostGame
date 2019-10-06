using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazardous : MonoBehaviour
{
    public Collider2D target;

    void Update()
    {
        Debug.Log(GetComponent<Collider2D>());
        Debug.Log(target);
        if (GetComponent<Collider2D>().IsTouching(target)) {
            Debug.Log("collision!");
        }
    }
}
