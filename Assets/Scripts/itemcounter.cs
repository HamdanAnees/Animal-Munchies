using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ItemCounter : MonoBehaviour
{
    public GameObject parent;

    private TextMeshProUGUI textMeshPro;

    private void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
        UpdateItemCount();
    }

    private void Update()
    {
        UpdateItemCount();
    }

    private void UpdateItemCount()
    {
        if (parent != null)
        {
            int childCount = parent.transform.childCount;
            textMeshPro.text = (childCount-1).ToString();
        }
        else
        {
            Debug.LogWarning("Parent object is not assigned in the inspector.");
        }
    }
}