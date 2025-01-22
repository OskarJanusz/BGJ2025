using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private AudioClip EnemyDeath;
    [SerializeField] private AudioClip BulletSound;

    public float BulletSpeed;
    private Rigidbody2D BulletRb;

    void Start()
    {
        BulletRb = GetComponent<Rigidbody2D>();
        BulletRb.linearVelocity = transform.right * BulletSpeed;
        AudioSource.PlayClipAtPoint(BulletSound, transform.position);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        WalkEnemyScript enemy = collision.GetComponent<WalkEnemyScript>();

        if (enemy != null)
        {
            AudioSource.PlayClipAtPoint(EnemyDeath, transform.position);
            enemy.TakeDamage(1.0f);
        }
        Destroy(gameObject);
    }
}
