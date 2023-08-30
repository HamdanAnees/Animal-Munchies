using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MyItemSpawner : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    public GameObject itemPrefab;

    public void OnBeginDrag(PointerEventData eventData)
    {
        // Implement any logic you want when the drag begins
    }

    public void OnDrag(PointerEventData eventData)
    {
        // Implement any logic you want while dragging
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            Vector3 spawnPosition = hit.point;
            Quaternion spawnRotation = Quaternion.identity; // You might want to adjust the rotation

            Instantiate(itemPrefab, spawnPosition, spawnRotation);
        }

        Destroy(gameObject);
    }
}