using UnityEngine;
using TMPro;

public class BearyBehavior : MonoBehaviour
{
    private int count;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        count = 0;
    // Update the count display.
    SetCountText(); 
    winTextObject.SetActive(false);
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
             // Increment the count of "PickUp" objects collected.
            count = count + 1;
 // Update the count display.
    SetCountText();
           
        }
    }
    void SetCountText() 
   {
       countText.text =  "Count: " + count.ToString();
       if (count >= 12)
       {
           winTextObject.SetActive(true);
       }
   }

}
