using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float BulletSpeed;
    private Rigidbody2D BulletRb;

    void Start()
    {
        BulletRb = GetComponent<Rigidbody2D>();
        BulletRb.linearVelocity = transform.right * BulletSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        WalkEnemyScript enemy = collision.GetComponent<WalkEnemyScript>();

        if (enemy != null)
        {
            enemy.TakeDamage(1.0f);
        }
        Destroy(gameObject);
    }
}
