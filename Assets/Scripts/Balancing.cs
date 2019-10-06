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
    angularVelocity = Mathf.Sign(angularVelocity) * Mathf.Min(45, Mathf.Abs(angularVelocity));

    currentAngle += angularVelocity * Time.deltaTime;
    currentAngle = Mathf.Sign(currentAngle) * Mathf.Min(45, Mathf.Abs(currentAngle));

    transform.rotation = Quaternion.Euler(0, 0, currentAngle);
  }

  public void ApplyForce(float force)
  {
    angularVelocity += 2 * force;
  }
}
