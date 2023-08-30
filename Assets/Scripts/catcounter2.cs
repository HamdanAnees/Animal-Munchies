using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class catcounter2 : MonoBehaviour
{
    public int totalCats;
    public int currentCats;
    public TMP_Text catCounterText;

    // Start is called before the first frame update
    void Start()
    {
        UpdateCatCounterText();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space)) // You can replace this with your own logic
        //{
        //    Increment();
        //}
    }

    public void increment()
    {
        currentCats++;
        UpdateCatCounterText();
    }

    void UpdateCatCounterText()
    {
        catCounterText.text = $"{currentCats}/{totalCats}";
    }
}