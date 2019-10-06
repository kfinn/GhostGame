using UnityEngine;
using UnityEngine.UI;

public class TruckCounting : MonoBehaviour
{
  private const string PlayerPrefsKey = "TrucksDodged";

  enum State
  {
    Clear, Dodging
  }

  private State state;
  [HideInInspector]
  public int trucksDodged;
  public Text text;
  public GameObject truck;

  void Start()
  {
    state = State.Clear;
    trucksDodged = PlayerPrefs.GetInt(PlayerPrefsKey);
    if (trucksDodged > 0)
    {
      text.text = $"{trucksDodged} trucks dodged";
    }
  }

  void Update()
  {
    if (state == State.Clear)
    {
      if (truck.activeSelf)
      {
        state = State.Dodging;
      }
    }
    else
    {
      if (!truck.activeSelf)
      {
        state = State.Clear;
        trucksDodged++;
        PlayerPrefs.SetInt(PlayerPrefsKey, trucksDodged);
        text.text = $"{trucksDodged} trucks dodged";
      }
    }
  }
}
