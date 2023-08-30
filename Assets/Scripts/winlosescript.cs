using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class winlosescript : MonoBehaviour
{
    public GameObject wintext;
    public GameObject losetext;
    public GameObject healthbar;
    public GameObject catbar;
    public GameObject nextbutton;
    public GameObject completedscreen;
    // Update is called once per frame
    void Update()
    {
        if (healthbar.GetComponent<Image>().fillAmount==0) {
            losetext.SetActive(true);
            wintext.SetActive(false);
            nextbutton.SetActive(false);
            completedscreen.SetActive(true);
        }
        if (catbar.GetComponent<Image>().fillAmount == 1) {
            completedscreen.SetActive(true);
        }

    }
}
