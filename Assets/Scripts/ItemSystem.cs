using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSystem : MonoBehaviour
{
    public float radius = 5f;
    public float timeThreshold = 5f; // Adjust this threshold value as needed

    private float timeOnItem = 0f;
    private bool playerOnItem = false;

    private Vector3 originalScale;
    private SpriteRenderer itemSpriteRenderer;

    private void Start()
    {
        timeOnItem = 0f;
        playerOnItem = false;

        itemSpriteRenderer = GetComponent<SpriteRenderer>();
        originalScale = transform.localScale;
    }

    private void FixedUpdate()
    {
        if (playerOnItem)
        {
            timeOnItem += Time.deltaTime;

            if (timeOnItem >= timeThreshold)
            {
                ShrinkAndDestroy();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerOnItem = true;
        }
    }

    private void ShrinkAndDestroy()
    {
        StartCoroutine(ShrinkOverTime());
    }

    private IEnumerator ShrinkOverTime()
    {
        float elapsedTime = 0f;

        while (elapsedTime < timeThreshold)
        {
            float normalizedTime = elapsedTime / timeThreshold;
            transform.localScale = Vector3.Lerp(originalScale, Vector3.zero, normalizedTime);

            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // Add any item destruction logic here (e.g., play effects, update scores, etc.)
        Destroy(gameObject);
    }
}
