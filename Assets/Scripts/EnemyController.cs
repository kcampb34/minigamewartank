using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyController : MonoBehaviour
{
    public GameObject player;  // Reference to the player
    public float speed = 30.0f; // Enemy movement speed
    //private float turnSpeed = 50;
    public float horizontalInput;
    public float verticalInput;
    private float stopDistance = 5.0f;  // Distance at which CPU stops chasing the player
    public float xRange = 700;
    public float zRange = 700;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        // Keeping the player in bounds
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }

        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }

        // If there's a player to chase
        if (player != null)
        {
            // Get the direction from the CPU to the player
            Vector3 direction = player.transform.position - transform.position;
            direction.y = 0;  // Ignore vertical difference (if needed for a flat plane)

            // Move towards the player if distance is greater than stopDistance
            if (direction.magnitude > stopDistance)
            {
                // Normalize the direction to ensure uniform movement speed
                Vector3 moveDirection = direction.normalized;

                // Move the CPU towards the player
                transform.position += moveDirection * speed * Time.deltaTime;

                // Optionally rotate to face the player
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(moveDirection), Time.deltaTime * 5.0f);
            }

        }

    }
}
