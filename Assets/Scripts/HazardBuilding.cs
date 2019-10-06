using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardBuilding : MonoBehaviour
{
  public GameObject hazard;

  private float lastHazardBuiltAt;

  void Start()
  {
    BuildHazard();
  }

  void Update()
  {
    if (Time.time > lastHazardBuiltAt + 10)
    {
      BuildHazard();
    }
  }

  private void BuildHazard() {
    var camera = Camera.main;
    var cameraHalfHeight = camera.orthographicSize;
    var cameraHalfWidth = cameraHalfHeight * camera.aspect;
    var x = Random.Range(-cameraHalfWidth, cameraHalfWidth);

    hazard.SetActive(true);
    hazard.transform.position = new Vector3(
        x,
        hazard.transform.position.y,
        hazard.transform.position.z
    );

    lastHazardBuiltAt = Time.time;
  }
}
