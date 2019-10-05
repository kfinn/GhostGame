using System;
using UnityEngine;

public class Draggable : MonoBehaviour
{
  struct Drag
  {
    public Vector3 startPosition;
    public Vector3 startMousePosition;
  }

  private Nullable<Drag> currentDrag;

  void Start()
  {
  }

  void Update()
  {
    var mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

    if (Input.GetMouseButtonDown(0))
    {
      if (GetComponent<Collider2D>().OverlapPoint(new Vector2(mouseWorldPosition.x, mouseWorldPosition.y)))
      {
        currentDrag = new Drag
        {
          startPosition = transform.position,
          startMousePosition = mouseWorldPosition
        };
      }
    }
    else if (Input.GetMouseButtonUp(0))
    {
      currentDrag = null;
    }
    else
    {
      if (currentDrag is Drag drag)
      {
        var mouseDiff = mouseWorldPosition - drag.startMousePosition;
        GetComponent<TargetSeeking>().targetPosition = new Vector3(
            drag.startPosition.x + mouseDiff.x,
            drag.startPosition.y + mouseDiff.y,
            drag.startPosition.z
        );
      }
    }
  }
}
