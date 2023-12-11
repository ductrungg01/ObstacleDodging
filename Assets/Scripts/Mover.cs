using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = moveSpeed * Time.deltaTime * Input.GetAxis("Horizontal");
        float zValue = moveSpeed * Time.deltaTime * Input.GetAxis("Vertical");
        
        transform.Translate(xValue, 0, zValue);
    }
}
