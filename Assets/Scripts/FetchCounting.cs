using UnityEngine;
using UnityEngine.UI;

public class FetchCounting : MonoBehaviour
{
  private const string PlayerPrefsKey = "FetchesFetched";

  enum State
  {
    Waiting, Dragging, Thrown, Carrying
  }

  public Draggable ballDraggable;
  public Carrying ballCarrying;
  public Text text;

  [HideInInspector]
  public int fetches;

  private State state;

  // Start is called before the first frame update
  void Start()
  {
    state = State.Waiting;
    fetches = PlayerPrefs.GetInt(PlayerPrefsKey);

    if (fetches > 0)
    {
      text.text = $"{fetches} fetches";
    }
  }

  // Update is called once per frame
  void Update()
  {
    if (state == State.Waiting)
    {
      if (ballDraggable.Dragged())
      {
        state = State.Dragging;
      }
    }
    else if (state == State.Dragging)
    {
      if (!ballDraggable.Dragged())
      {
        state = State.Thrown;
      }
    }
    else if (state == State.Thrown)
    {
      if (ballCarrying.carried != null)
      {
        state = State.Carrying;
      }
    }
    else if (state == State.Carrying)
    {
      if (ballCarrying.carried == null)
      {
        state = State.Waiting;
        fetches++;
        PlayerPrefs.SetInt(PlayerPrefsKey, fetches);
        text.text = $"{fetches} fetches";
      }
    }
  }
}
