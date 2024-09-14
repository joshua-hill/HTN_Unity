using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animator animator;

    // Method to trigger animation based on an event
    public void TriggerAnimation(string animationName)
    {
        // Set trigger in Animator to transition to the desired state
        if (animationName == "Dying")
        {
            animator.SetTrigger("dying"); 
        }
        if (animationName == "Reaction")
        {
            animator.SetTrigger("reaction");  
        }
    }
}
