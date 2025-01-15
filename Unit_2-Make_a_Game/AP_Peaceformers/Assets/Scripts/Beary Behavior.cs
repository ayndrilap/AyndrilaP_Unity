using UnityEngine;

public class BearyBehavior : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnTriggerEnter(Collider other) 
    {
 // Check if the object the player collided with has the "PickUp" tag.
 if (other.gameObject.CompareTag("Pingus")) 
        {
 // Deactivate the collided object (making it disappear).
            other.gameObject.SetActive(false);
        }
    }

}
