using UnityEngine;
using UnityEngine.UI;

public class Summarizing : MonoBehaviour
{
    void Start()
    {
        GetComponent<Text>().text = $"{BikesBuilt()} Bikes built\n\n{FetchesFetched()} Balls fetched\n\n{TrucksDodged()} Trucks dodged";
    }

    private int BikesBuilt() {
        return PlayerPrefs.GetInt(EnablingAfterPuzzleSolved.PlayerPrefsKey);
    }

    private int FetchesFetched() {
        return PlayerPrefs.GetInt(FetchCounting.PlayerPrefsKey);
    }

    private int TrucksDodged() {
        return PlayerPrefs.GetInt(TruckCounting.PlayerPrefsKey);
    }
}
