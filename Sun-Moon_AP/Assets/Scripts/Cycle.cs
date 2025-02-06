using UnityEngine;
using System;

public class Cycle : MonoBehaviour
{   
    public float speed = 5;
    private float angle = 0;
    public GameObject daylight;
    public GameObject nightlight;
    [SerializeField]
    Transform daylightPivot, nightlightPivot;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void ChangeAngle()
    {
        
        angle +=speed;
        Quaternion rot = Quaternion.Euler (angle, 100,90);
        daylight.transform.rotation = rot;
        nightlight.transform.rotation = rot;
    }

   void Update(){
    var time = DateTime.Now;
    Debug.Log(DateTime.Now);
    ChangeAngle();
    daylightPivot.localRotation = 
            Quaternion.Euler( 0, 0, angle * time.Hour);
   }
}
