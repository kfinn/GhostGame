﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionRandomized : MonoBehaviour
{
  [HideInInspector]
  public Vector3 initialPosition;

  void Start()
  {
    initialPosition = transform.position;

    var camera = Camera.main;
    var cameraHalfHeight = camera.orthographicSize;
    var cameraHalfWidth = cameraHalfHeight * camera.aspect;

    var x = Random.Range(-cameraHalfWidth, cameraHalfWidth);
    var y = Random.Range(-cameraHalfHeight, cameraHalfHeight);

    transform.position = new Vector3(
        x,
        y,
        transform.position.z
    );
  }
}
