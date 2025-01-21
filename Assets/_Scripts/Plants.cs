using UnityEngine;

public class Plants : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out PlayerMovement playerMovement))
        {
            playerMovement.TakeDamage();
        }
    }
}
