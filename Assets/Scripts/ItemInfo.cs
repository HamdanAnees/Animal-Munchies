using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInfo : MonoBehaviour
{
    public float radius = 5f;
    public float timeThreshold = 5f; // Adjust this threshold value as needed

    private float timeOnItem = 0f;
    private bool playerOnItem = false;

    private void FixedUpdate()
    {
        if (playerOnItem)
        {
            timeOnItem += Time.deltaTime;

            if (timeOnItem >= timeThreshold)
            {
                DestroyItem();
            }
        }
        else
        {
            timeOnItem = 0f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Player entered item trigger 1");
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entered item trigger 1");
            playerOnItem = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerOnItem = false;
        }
    }

    private void DestroyItem()
    {
        Debug.Log("Item Destroyed!");
        // Add any item destruction logic here (e.g., play effects, update scores, etc.)
        Destroy(gameObject);
    }
}