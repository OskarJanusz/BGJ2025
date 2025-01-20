using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    [SerializeField] string groundTag;

    public bool isGrounded { get; private set; } = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag(groundTag))
        {
            isGrounded = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag(groundTag))
        {
            isGrounded = true;
        }
    }
}
