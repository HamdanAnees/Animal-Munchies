using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthbarscript : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = player.transform.position.x;
        float z = 0.9f+player.transform.position.z;
        //float y = transform.position.y;
        float y = player.transform.position.y;
        Quaternion rot = transform.rotation;
        transform.SetPositionAndRotation(new Vector3(x,y,z), rot);
    }
}
