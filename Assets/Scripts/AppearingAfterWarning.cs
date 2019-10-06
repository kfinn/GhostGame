using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearingAfterWarning : MonoBehaviour
{
    public GameObject toAppear;
    public GameObject warning;

    private float startedOn;
    private bool appeared;
    private bool disappeared;

    void OnEnable()
    {
        toAppear.SetActive(false);
        warning.SetActive(true);

        startedOn = Time.time;

        appeared = false;
        disappeared = false;
    }

    void Update()
    {
        if (Time.time > startedOn + 3 && !appeared) {
            warning.SetActive(false);
            toAppear.SetActive(true);
            appeared = true;
        } else if (Time.time > startedOn + 6) {
            gameObject.SetActive(false);
        }
    }
}
