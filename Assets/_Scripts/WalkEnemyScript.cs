using UnityEngine;

public class WalkEnemyScript : MonoBehaviour
{
    [SerializeField] private float EnemyHealth = 1.0f;
    [SerializeField] private float EnemySpeed = 5.0f;
    [SerializeField] private Transform LeftPoint;
    [SerializeField] private Transform RightPoint;

    private Rigidbody2D EnemyRb;
    private bool isMovingRight = true;

    private Vector3 LeftPointPosition;
    private Vector3 RightPointPosition;

    private void Start()
    {
        EnemyRb = GetComponent<Rigidbody2D>();

        LeftPointPosition = LeftPoint.position;
        RightPointPosition = RightPoint.position;
    }

    private void Update()
    {
        float MoveValue = EnemySpeed * Time.deltaTime;
        if(isMovingRight)
        {
            transform.position = Vector3.MoveTowards(transform.position, RightPointPosition, MoveValue);
            if(transform.position == RightPointPosition)
            {
                isMovingRight = false;
            }
        }

        else
        {
            transform.position = Vector3.MoveTowards(transform.position, LeftPointPosition, MoveValue);
            if (transform.position == LeftPointPosition)
            {
                isMovingRight = true;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out PlayerMovement playerMovement))
        {
            playerMovement.TakeDamage();
        }
    }
    public void TakeDamage(float damage)
    {
        EnemyHealth -= damage;
        if (EnemyHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
