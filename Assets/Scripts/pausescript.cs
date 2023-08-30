using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausescript : MonoBehaviour
{
    public void pausegame() {
        Time.timeScale = 0;
    }
    public void resumegame() {
        Time.timeScale = 1;
    }
}
