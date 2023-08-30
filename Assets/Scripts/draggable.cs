using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class draggable : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler, IPointerDownHandler
{
    [HideInInspector] public Transform parentAfter; // Correct variable name
    public UnityEngine.UI.Image i;

    public void OnBeginDrag(PointerEventData eventData)
    {
        parentAfter = transform.parent; // Correct variable name
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
        i.raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
        //transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.SetParent(parentAfter);
        i.raycastTarget = true;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
    }
}
