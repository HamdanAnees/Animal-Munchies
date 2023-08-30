using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    private NavMeshAgent agent;
    private GameObject nearestItem;
    private float nearestDistance;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        FindAndMoveToNearestItem();
    }

    void FindAndMoveToNearestItem()
    {
        GameObject[] items = GameObject.FindGameObjectsWithTag("item");

        nearestItem = null;
        nearestDistance = Mathf.Infinity;

        foreach (GameObject item in items)
        {
            float distance = Vector3.Distance(transform.position, item.transform.position);
            float itemRadius = item.GetComponent<ItemSystem>().radius;

            if (distance <= itemRadius && distance < nearestDistance)
            {
                nearestItem = item;
                nearestDistance = distance;
            }
        }

        if (nearestItem != null)
        {
            agent.SetDestination(nearestItem.transform.position);
        }
    }
}