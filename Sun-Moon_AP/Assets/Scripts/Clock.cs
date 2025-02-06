//Ayndrila Pual
//period 7-8
// This code controls the hour, minute and second hand.
using System;
using UnityEngine; // this imports preBuild functions for Unity

// a class defines an object and
// public makes it available for all.
public class Clock : MonoBehaviour
// curly brackets make a block of code
{
// inside the curly brackets is the code for this object
// {} are a container for information
// to rotate the arms we need to declare them here
[SerializeField]
Transform hoursPivot, minutesPivot, secondsPivot;

const float hoursToDegrees = - 30;
const float minutesToDegrees = -6;
const float secondsToDegrees = -6;
// declare a function
void Update()
    {
        //declare a variable for time
        var time = DateTime.Now;
        //this is only inside the Awake function
        Debug.Log(DateTime.Now);
        hoursPivot.localRotation = 
            Quaternion.Euler( 0, 0, hoursToDegrees * time.Hour);
        minutesPivot.localRotation =
            Quaternion.Euler( 0, 0, minutesToDegrees * time.Minute);
        secondsPivot.localRotation =
             Quaternion.Euler( 0, 0, secondsToDegrees * time.Second);

    }
}
