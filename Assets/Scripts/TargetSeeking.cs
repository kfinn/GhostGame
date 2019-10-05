using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSeeking : MonoBehaviour
{
  [HideInInspector]
  public Vector3 targetPosition;

  void Start()
  {
    targetPosition = transform.position;
  }

  void FixedUpdate()
  {
    transform.position = new Vector3(
        (targetPosition.x + (transform.position.x * 2)) / 3,
        (targetPosition.y + (transform.position.y * 2)) / 3,
        transform.position.z
    );
  }
}
