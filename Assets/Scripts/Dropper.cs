using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] private float timeToAppear = 3f;
    private bool dropped = false;
    
    private Rigidbody rb;
    private MeshRenderer mesh;
    
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();

        mesh.enabled = false;
        rb.useGravity = false;
    }

    void Update()
    {
        if (!dropped)
        {
            timeToAppear -= Time.deltaTime;
            if (timeToAppear <= 0)
            {
                rb.useGravity = true;
                mesh.enabled = true;
                dropped = true;
            }
        }
    }
}
