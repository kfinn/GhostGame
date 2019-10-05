using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFollowing : MonoBehaviour
{
  void Start()
  {
  }

  void FixedUpdate()
  {
    if (Input.GetMouseButtonDown(0) || Input.GetMouseButton(0))
    {
      GetComponent<TargetSeeking>().targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
  }
}
