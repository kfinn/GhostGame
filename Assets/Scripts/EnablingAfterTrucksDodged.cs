using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnablingAfterTrucksDodged : MonoBehaviour
{

  public GameObject toEnable;
  public TruckCounting truckCounting;

  void Start()
  {
      if (truckCounting.trucksDodged > 3) {
          toEnable.SetActive(true);
      }
  }


  void Update()
  {
      if (truckCounting.trucksDodged > 3 && !toEnable.activeSelf) {
          toEnable.SetActive(true);
      }
  }
}
