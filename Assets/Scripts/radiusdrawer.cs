using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class radiusdrawer : MonoBehaviour, IDragHandler, IEndDragHandler
{
    public GameObject itemobj;
    public GameObject radiusobj;
    public void OnDrag(PointerEventData eventData)
    {
        radiusobj.SetActive(true);
        float radius = itemobj.GetComponent<ItemSystem>().radius;
        Vector3 radiussize = new Vector3(radius + 2, radius + 2, radius + 2);
        radiusobj.transform.localScale = radiussize;
        radiusobj.transform.position = transform.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        radiusobj.SetActive(false);
    }
}
