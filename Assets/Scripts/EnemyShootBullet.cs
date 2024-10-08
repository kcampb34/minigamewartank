using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShootBullet : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float shootInterval = 2.0f;  // Time between shots
    private float shootTimer = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        shootTimer = shootInterval; // Initialize the shoot timer
    }

    // Update is called once per frame
    void Update()
    {
        shootTimer -= Time.deltaTime;

        if (shootTimer <= 0f)
        {
            Shoot();
            shootTimer = shootInterval;  // Reset timer after shooting
        }
    }

    void Shoot()
    {
        // Launch a projectile from the CPU's position and rotation
        Instantiate(projectilePrefab, transform.position, transform.rotation);
    }
}
