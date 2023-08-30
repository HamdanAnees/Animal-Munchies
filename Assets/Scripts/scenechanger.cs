using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenechanger : MonoBehaviour
{
    public string sceneName;
    public void loadscene() { 
        SceneManager.LoadScene(sceneName);
    }
    public void loadlevel(int num)
    {   
            //removed the if statement and added num+1 for level 1
            SceneManager.LoadScene(num+1);
    }
    public void nextscene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    public void restartscene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
