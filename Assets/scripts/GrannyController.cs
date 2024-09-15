using System;
using UnityEngine;
using System.Collections.Generic;

public class AnimationController : MonoBehaviour
{
    private Animator animator;

    // Method to trigger animation based on an event
    public void ChangeAnimation(string parameter)
    {
        Debug.Log("ChangeAnimation called from JavaScript");
        //prameter will be the trigger name in unity
        animator.SetTrigger(parameter); 
    }
}
