using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Rigidbody enemyRigidbody;
    public float speed = 10f;

    private void Start()
    {
        // Cache the Rigidbody component for better performance
        enemyRigidbody = GetComponent<Rigidbody>();

        // Make sure there's a Rigidbody component on the enemy object
        if (enemyRigidbody == null)
        {
            Debug.LogError("No Rigidbody component found on the enemy object.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Lock the Z and X rotations of the enemy
        Vector3 newRotation = new Vector3(0f, transform.eulerAngles.y, 0f);
        transform.eulerAngles = newRotation;

        // Move the enemy forward based on its own position
        Vector3 forwardDirection = transform.forward;
        enemyRigidbody.velocity = forwardDirection * speed;

        // Show a visible ray of the enemy's movement direction
        Debug.DrawRay(transform.position, forwardDirection * 2f, Color.red);
    }
}
