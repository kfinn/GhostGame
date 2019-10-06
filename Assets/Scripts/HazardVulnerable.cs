using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardVulnerable : MonoBehaviour
{
  public GameObject collisionGO;

  void OnCollisionEnter2D(Collision2D collision)
  {
    Debug.Log("Contact!");
    var contact = collision.GetContact(0);

    collisionGO.SetActive(true);
    collisionGO.transform.position = new Vector3(
        contact.point.x,
        contact.point.y,
        collisionGO.transform.position.z
    );
  }
}
