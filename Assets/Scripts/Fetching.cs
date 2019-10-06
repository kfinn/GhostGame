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
    var carrying = GetComponent<Carrying>();
    var ballGameObject = ballTransform.gameObject;

    var ballNearThrower = Mathf.Abs(ballTransform.position.x - throwerTransform.position.x) < 2;

    if (ballNearThrower || carrying.carried == ballGameObject)
    {
      chasing.target = throwerTransform;

      var absDistanceToThrower = Mathf.Abs(throwerTransform.position.x - transform.position.x);
      if (absDistanceToThrower > 1)
      {
        var targetOffsetSign = transform.position.x < throwerTransform.position.x ? -1 : 1;
        chasing.targetOffsetX = targetOffsetSign * 2;
      }

      if (absDistanceToThrower <= 2)
      {
        carrying.carried = null;
      }
    }
    else
    {
      chasing.target = ballTransform;

      var absDistanceXToBall = Mathf.Abs(ballTransform.position.x - transform.position.x);
      if (absDistanceXToBall < 0.5)
      {
        if (ballTransform.position.y < transform.position.y + 0.5)
        {
          carrying.carried = ballGameObject;
        }
      }
      else
      {
        var targetOffsetSign = transform.position.x < ballTransform.position.x ? 1 : -1;
        chasing.targetOffsetX = targetOffsetSign * 4;

      }
    }
  }
}
