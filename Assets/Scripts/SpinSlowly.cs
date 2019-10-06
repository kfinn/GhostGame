using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinSlowly : MonoBehaviour
{

  void Update()
  {
    GetComponent<Rigidbody2D>().angularVelocity = -2;
  }
}
