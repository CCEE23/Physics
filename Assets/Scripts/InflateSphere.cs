using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallT : MonoBehaviour
{

    [Header("Configuration Settings")]
    [Space]
    [Tooltip("Speed of Scale Change")]
    [Range(0,50)]
    public int speed = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale += new Vector3(0.1f, 0.1f, 0.1f) * Time.deltaTime * speed;
    }
}
