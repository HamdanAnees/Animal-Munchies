using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shadowcheck : MonoBehaviour
{
    public SpriteRenderer s;
    // Start is called before the first frame update
    void Start()
    {
        s.receiveShadows = true;
        s.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
    }

  
}
