using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animator animator;

    // Method to trigger animation based on an event
    public void ChangeAnimation(string parameter)
    {
        Debug.Log("ChangeAnimation called from JavaScript");
        if (parameter == "Dying")
        {
            animator.SetTrigger("dying"); 
        }
        if (parameter == "Reaction")
        {
            animator.SetTrigger("reaction");  
        }
    
    }
}
