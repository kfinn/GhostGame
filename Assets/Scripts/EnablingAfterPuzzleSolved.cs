using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnablingAfterPuzzleSolved : MonoBehaviour
{
    public GameObject toEnable;
    public int piecesCount;

    void Update()
    {
        if (!toEnable.activeSelf && GetComponent<RelativeInitialPositionRestoring>().AttachedPiecesCount() == piecesCount) {
            toEnable.SetActive(true);
        }
    }
}
