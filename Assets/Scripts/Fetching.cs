using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Fetching : MonoBehaviour
{
  public Transform ballTransform;
  public Transform throwerTransform;


  void Start()
  {
    GetComponent<Chasing>().target = ballTransform;
  }

  void Update()
  {
    var chasing = GetComponent<Chasing>();
    if (Mathf.Abs(ballTransform.position.x - throwerTransform.position.x) < 2)
    {
      chasing.target = throwerTransform;
      chasing.targetOffsetX = 3;
    }
    else
    {
      if (chasing.target != ballTransform)
      {
        chasing.target = ballTransform;

        if (Mathf.Abs(ballTransform.position.x - transform.position.x) > 4)
        {
          var targetOffsetSign = transform.position.x < ballTransform.position.x ? 1 : -1;
          chasing.targetOffsetX = targetOffsetSign * 3;
        }
      }
    }
  }
}
