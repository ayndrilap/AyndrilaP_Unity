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

float hoursToDegrees = -30;
// declare a function
void Awake()
    {
        //this is only inside the Awake function
        Debug.Log(DateTime.Now);
        hoursPivot.localRotation = 
            Quaternion.Euler( 0, 0, hoursToDegrees * DateTime.Now.Hour);

    }
}
