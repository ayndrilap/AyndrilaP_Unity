using UnityEngine;



public class CylinderRotation : MonoBehaviour

{

    public float rotationSpeed = 30f; // Rotation speed per frame



    void Update()

    {

        // Rotate the cylinder around its Y-axis

        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime); 

    }

}
