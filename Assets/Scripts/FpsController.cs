using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FpsController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.deltaTime + " seg., " + 1.0f / Time.deltaTime + " FPS");
    }
    void FixedUpdate()
    {
        //Debug.Log(Time.deltaTime + " seg., " + 1.0f / Time.deltaTime + " FPS");
    }

}
