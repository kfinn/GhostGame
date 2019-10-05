using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFollowing : MonoBehaviour
{
  private Vector3 targetPosition;

  void Start()
  {
      targetPosition = transform.position;
  }

  void FixedUpdate()
  {
    if (Input.GetMouseButtonDown(0) || Input.GetMouseButton(0))
    {
      targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    transform.position = new Vector3(
        (targetPosition.x + (transform.position.x * 2)) / 3,
        (targetPosition.y + (transform.position.y * 2)) / 3,
        transform.position.z
    );
  }
}
