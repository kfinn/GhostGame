using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Voice : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    void Start()
    {
        Update();
    }

    // Update is called once per frame
    void Update()
    {
        var targetScreenPosition = Camera.main.WorldToScreenPoint(target.position) + offset;
        GetComponent<RectTransform>().position = new Vector3(
            targetScreenPosition.x,
            targetScreenPosition.y,
            targetScreenPosition.z
        );
    }
}
