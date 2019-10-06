using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnablingAfterTrigger : MonoBehaviour
{
  public string playerPrefsOverride;
  public GameObject toEnable;
  public GameObject character;

  void Start()
  {
    if (playerPrefsOverride != null && PlayerPrefs.GetInt(playerPrefsOverride) > 0)
    {
      toEnable.SetActive(true);
      gameObject.SetActive(false);
    }
    else
    {
      toEnable.SetActive(false);
    }
  }

  void Update()
  {
    if (GetComponent<Collider2D>().OverlapPoint(character.transform.position))
    {
      toEnable.SetActive(true);
      gameObject.SetActive(false);
    }
  }
}
