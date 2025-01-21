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
}
