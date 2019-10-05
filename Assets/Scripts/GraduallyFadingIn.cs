using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraduallyFadingIn : MonoBehaviour
{
  private int clicksCount = 0;

  void Start()
  {
    GetComponent<SpriteRenderer>().color = Color.clear;
  }

  void Update()
  {
    if (Input.GetMouseButtonDown(0))
    {
      clicksCount += 1;
      GetComponent<SpriteRenderer>().color = Color.Lerp(Color.clear, Color.white, Mathf.Min(1, clicksCount / 4.0f));
    }
  }
}
