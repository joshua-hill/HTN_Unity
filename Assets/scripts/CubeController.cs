using UnityEngine;

public class CubeController : MonoBehaviour
{
    public Animator animator;

    public void ChangeAnimation(string parameter)
    {
        Debug.Log("ChangeAnimation called from JavaScript");
        animator.SetTrigger("NextAnimation");
    }
}
