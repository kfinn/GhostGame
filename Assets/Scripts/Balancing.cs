using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balancing : MonoBehaviour
{
  [HideInInspector]
  public float currentAngle;
  private float angularVelocity = 10;

  void Start()
  {
  }

  // Update is called once per frame
  void Update()
  {
    currentAngle += angularVelocity * Time.deltaTime;
    transform.rotation = Quaternion.Euler(0, 0, currentAngle);
  }

  public void ApplyForce(float force)
  {
    angularVelocity += force;
  }
}
