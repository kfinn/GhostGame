using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostAnimatorOrienting : MonoBehaviour
{
    public Animator ghostAnimator;

    void Start()
    {
        ghostAnimator.SetFloat("dx", 0);
    }

    // Update is called once per frame
    void Update()
    {
        ghostAnimator.SetFloat("dx", GetComponent<TargetSeeking>().targetPosition.x - transform.position.x);
    }
}
