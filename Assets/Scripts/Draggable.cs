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
  private Nullable<Drag> previousDrag;

  void Start()
  {
  }

  void Update()
  {
    previousDrag = currentDrag;
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
        var target = new Vector3(
          drag.startPosition.x + mouseDiff.x,
          drag.startPosition.y + mouseDiff.y,
          drag.startPosition.z
        );
        if (GetComponent<TargetSeeking>() is TargetSeeking targetSeeking)
        {
          GetComponent<TargetSeeking>().targetPosition = target;
        }
        else
        {
          if (GetComponent<Rigidbody2D>() is Rigidbody2D rigidbody) {
            rigidbody.velocity = (target - transform.position) * 7;
          }
          transform.position = target;
        }
      }
    }

    float scale = currentDrag == null ? 1 : 1.1f;
    transform.localScale = new Vector3(scale, scale, 1);
  }

  public bool Dragged()
  {
    return currentDrag != null;
  }

  public bool DroppedThisFrame()
  {
    return previousDrag != null && currentDrag == null;
  }
}
