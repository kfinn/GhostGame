using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carrying : MonoBehaviour
{
  public GameObject carried;
  public Vector3 carriedOffset;

  void Start()
  {

  }

  void Update()
  {
    if (carried != null)
    {
        var newPosition = transform.position + carriedOffset;
        carried.GetComponent<Rigidbody2D>().velocity = newPosition - carried.transform.position;
        carried.transform.position = newPosition;
    }
  }
}
