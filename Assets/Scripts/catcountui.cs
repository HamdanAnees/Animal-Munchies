using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class catcountui : MonoBehaviour
{
    public int totalcats;
    public int currentcats;
    public Image bar;
    int totalwidth;

    // Start is called before the first frame update
    void Start()
    {
        totalwidth = (int)bar.rectTransform.sizeDelta.x;
    }

    // Update is called once per frame
    void Update()
    {
        float fillAmount = (float)currentcats / totalcats;
        bar.fillAmount = fillAmount;
    }

    public void increment()
    {
        currentcats++;
    }
}