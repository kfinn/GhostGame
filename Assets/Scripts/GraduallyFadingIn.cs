using UnityEngine;

public class GraduallyFadingIn : MonoBehaviour
{
  private const string FadedInKey = "GraduallyFadingIn.FadedInKey";
  private int clicksCount = 0;

  void Start()
  {
    if (PlayerPrefs.GetInt(FadedInKey) > 0) {
      clicksCount = 5;
    } else {
      GetComponent<SpriteRenderer>().color = Color.clear;
    }
  }

  void Update()
  {
    if (Input.GetMouseButtonDown(0))
    {
      clicksCount += 1;
      GetComponent<SpriteRenderer>().color = Color.Lerp(Color.clear, Color.white, Mathf.Min(1, clicksCount / 4.0f));
      if (clicksCount == 4) {
        PlayerPrefs.SetInt(FadedInKey, PlayerPrefs.GetInt(FadedInKey) + 1);
      }
    }
  }
}
