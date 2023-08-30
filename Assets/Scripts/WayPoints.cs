using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour
{
    public GameObject[] waypoints;
    public GameObject objectPrefab;
    public float speed;
    public float yRotationAngle;
    public float spawnDelay = 2.0f; // Delay before spawning the initial object
    int current = 0;
    float WPradius = 1;
    float spawnTimer = 0; // Timer for spawn delay

    public GameObject spawnedObject;
    public LineRenderer lineRenderer;
    public GameObject progressbar;
    public GameObject textcounter;

    void Start()
    {
        spawnTimer = spawnDelay;
    }

    void Update()
    {
        if (spawnedObject == null)
        {
            if (spawnTimer > 0)
            {
                spawnTimer -= Time.deltaTime;
            }
            else
            {
                SpawnObject();
                spawnTimer = float.MaxValue; // Set a large value to prevent further spawns
            }
        }
        else if (current < waypoints.Length)
        {
            if (Vector3.Distance(waypoints[current].transform.position, spawnedObject.transform.position) < WPradius)
            {
                current++;
                if (current >= waypoints.Length)
                {
                    DestroyObjectAndLine();
                }
            }
            else
            {
                spawnedObject.transform.position = Vector3.MoveTowards(spawnedObject.transform.position, waypoints[current].transform.position, Time.deltaTime * speed);
                spawnedObject.transform.rotation = Quaternion.Euler(0, yRotationAngle, 0);
            }

            UpdateLineRenderer();
        }
    }

    public void SpawnObject()
    {
        spawnedObject = Instantiate(objectPrefab, waypoints[0].transform.position, Quaternion.identity);
        UpdateLineRenderer();
    }

    void UpdateLineRenderer()
    {
        if (lineRenderer != null && spawnedObject != null && current < waypoints.Length)
        {
            lineRenderer.SetPosition(0, spawnedObject.transform.position);
            lineRenderer.SetPosition(1, waypoints[current].transform.position);
        }
    }

    void DestroyObjectAndLine()
    {
        if (spawnedObject != null)
        {
            Destroy(spawnedObject);
        }
        if (lineRenderer != null)
        {
            Destroy(lineRenderer.gameObject);
        }
        progressbar.GetComponent<catcountui>().increment();
        textcounter.GetComponent<catcounter2>().increment();
    }
}
