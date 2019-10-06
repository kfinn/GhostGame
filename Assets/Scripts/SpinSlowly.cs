using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinSlowly : MonoBehaviour
{

  public float angularVelocity = -2;

  void Update()
  {
    GetComponent<Rigidbody2D>().angularVelocity = angularVelocity;
  }
}
