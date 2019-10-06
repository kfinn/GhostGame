using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnablingAfterTrigger : MonoBehaviour
{
    public GameObject toEnable;
    public GameObject character;

    void Update()
    {
        if (GetComponent<Collider2D>().OverlapPoint(character.transform.position)) {
            toEnable.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
