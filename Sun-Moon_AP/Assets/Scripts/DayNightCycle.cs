using UnityEngine;
using System.Collections;

public class DayNightCycle : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      transform.RotateAround(Vector3.zero,Vector3.right,40f*Time.deltaTime); 
      transform.LookAt(Vector3.zero);
    }
}
