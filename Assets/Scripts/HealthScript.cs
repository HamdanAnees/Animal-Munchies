using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{
    public float health;
    public float eyeFrameDuration = 1.0f; // Duration of the eye frames in seconds
    public GameObject bar;

    private bool isInvincible = false; // Flag to track invincibility

    // Start is called before the first frame update
    void Start()
    {
        health = 1f;
    }

    // Called when a collision occurs
    private void OnCollisionEnter(Collision col)
    {
        if (col.collider.CompareTag("Enemy") && !isInvincible)
        {
            // Reduce health when hit by an enemy
            health -= 0.25f;
            Debug.Log("Player Health: " + health);

            // Activate invincibility frames
            StartCoroutine(ActivateEyeFrames());

            if (health <= 0)
            {
                Die();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy") && !isInvincible)
        {
            // Reduce health when hit by an enemy
            health -= 0.25f;
            Debug.Log("Player Health: " + health); 
            bar.GetComponent<Image>().fillAmount = health;

            // Activate invincibility frames
            StartCoroutine(ActivateEyeFrames());

            if (health <= 0)
            {
                Die();
            }
        }
    }

    // Coroutine to activate invincibility frames
    private IEnumerator ActivateEyeFrames()
    {
        isInvincible = true;
        yield return new WaitForSeconds(eyeFrameDuration);
        isInvincible = false;
    }

    // Implement what happens when the player dies
    private void Die()
    {
        // Example: Deactivate the player or trigger a game over
        gameObject.SetActive(false);
    }
}
