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

    var builtHazard = Instantiate(
        hazard
    );

    builtHazard.transform.position = new Vector3(
        x,
        builtHazard.transform.position.y,
        builtHazard.transform.position.z
    );

    lastHazardBuiltAt = Time.time;
  }
}
