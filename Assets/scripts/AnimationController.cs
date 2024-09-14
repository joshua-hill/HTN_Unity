using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animator animator;

    // Method to trigger animation based on an event
    public void TriggerAnimation(string animationName)
    {
        // Set trigger in Animator to transition to the desired state
        // if (animationName == "Move")
        // {
            animator.SetTrigger("MoveTrigger");  // Example trigger for a move event
        // }
        // Add more conditions for different animations as needed
    }
}
