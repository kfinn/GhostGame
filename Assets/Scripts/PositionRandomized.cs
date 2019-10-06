using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionRandomized : MonoBehaviour
{
  void Start()
  {
    var camera = Camera.main;
    var cameraHalfHeight = camera.orthographicSize;
    var cameraHalfWidth = cameraHalfHeight * camera.aspect;

    var x = Random.Range(-cameraHalfWidth, cameraHalfWidth);
    var y = Random.Range(-cameraHalfHeight, cameraHalfHeight);

    var target = new Vector3(
        x,
        y,
        transform.position.z
    );
    transform.position = target;
    if (GetComponent<TargetSeeking>() is TargetSeeking targetSeeking) {
      targetSeeking.targetPosition = target;
    }
  }
}
