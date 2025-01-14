using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Rotator : MonoBehaviour
{
    public float horizontal;
    public float speed = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * Time.deltaTime * speed * horizontal);
    }
}
