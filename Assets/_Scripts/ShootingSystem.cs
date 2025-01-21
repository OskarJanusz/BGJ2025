using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShootingSystem : MonoBehaviour
{
    [Range(0f, 2f)]

    public Transform ShootingPoint;
    public GameObject BulletPrefab;

    private float Timer = 0.25f;
    private float WaitTime = 0.25f;

    void Update()
    {
        if (Timer < WaitTime)
        {}

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Shoot();
            Timer = 0;
        }

        Timer += Time.deltaTime;
    }

    void Shoot()
    {
        Instantiate(BulletPrefab, ShootingPoint.position, transform.rotation);
    }
}
