using UnityEngine;

public class CubeController : MonoBehaviour
{
    public Animator animator;

    public void ChangeAnimation(string parameter)
    {
        Debug.Log("ChangeAnimation called from JavaScript");
        if(parameter == "")
        {
            animator.SetTrigger("NextAnimation");
        }
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
