using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikePuzzleLoading : MonoBehaviour
{
  private int clicksCount = 0;
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetMouseButtonDown(0))
    {
      clicksCount += 1;
      if (clicksCount == 10)
      {
        var bicyclePieces = Resources.Load("Prefabs/Bicycle Pieces");
        Instantiate(bicyclePieces);
      }
    }
  }
}
