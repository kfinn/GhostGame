using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnablingAfterPuzzleSolved : MonoBehaviour
{
    public const string PlayerPrefsKey = "BikesBuilt";

    public GameObject toEnable;
    public int piecesCount;

    void Update()
    {
        if (!toEnable.activeSelf && GetComponent<RelativeInitialPositionRestoring>().AttachedPiecesCount() == piecesCount) {
            PlayerPrefs.SetInt(PlayerPrefsKey, PlayerPrefs.GetInt(PlayerPrefsKey) + 1);
            toEnable.SetActive(true);
        }
    }
}
