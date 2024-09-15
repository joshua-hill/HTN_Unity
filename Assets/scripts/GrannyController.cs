using UnityEngine;

public class GrannyController : MonoBehaviour
{
    public Animator animator;

    // Initialize the animator component
    void Start()
    {
        // This assumes that the Animator component is attached to the same GameObject (SportyGranny).
        animator = GetComponent<Animator>();

        // If for some reason the Animator is not found, log an error.
        if (animator == null)
        {
            Debug.LogError("Animator component not found on the GameObject.");
        }
    }

    // Method to trigger animation based on an event
    public void ChangeAnimation(string parameter)
    {
        if (animator != null)
        {
            Debug.Log("ChangeAnimation called from JavaScript with parameter: " + parameter);
            animator.SetTrigger(parameter);
        }
        else
        {
            Debug.LogError("Animator is not assigned or found.");
        }
    }
}
