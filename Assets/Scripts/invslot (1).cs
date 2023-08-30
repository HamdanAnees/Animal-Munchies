using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class invslot : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        if (transform.childCount == 0) {
        GameObject dropped = eventData.pointerDrag;
        draggable s = dropped.GetComponent<draggable>();
        s.parentAfter = transform;
        throw new System.NotImplementedException();
        }
    }

}
