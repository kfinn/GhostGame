using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnablingAfterFetchesFetched : MonoBehaviour
{
  public GameObject toEnable;
  public FetchCounting fetchCounting;

  void Start()
  {
    if (fetchCounting.fetches > 5)
    {
      toEnable.SetActive(true);
    }
  }

  void Update()
  {
    if (fetchCounting.fetches > 5 && !toEnable.activeSelf)
    {
      toEnable.SetActive(true);
    }
  }
}
