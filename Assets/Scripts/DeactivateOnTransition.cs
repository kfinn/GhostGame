using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateOnTransition : StateMachineBehaviour
{
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.gameObject.SetActive(false);
    }
}
