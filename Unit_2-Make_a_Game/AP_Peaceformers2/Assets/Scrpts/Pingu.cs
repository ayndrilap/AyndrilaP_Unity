using UnityEngine;


public class Spin : MonoBehaviour
{
   
    // Update is called once per frame
    void Update()
    {
       transform.Rotate ( 0, .5f, 0);
    }
   
    void OnTriggerEnter(Collider other) {
    if (other.CompareTag("Beary")) {
        Debug.Log("Collected an item!");
        Destroy(gameObject);
         }
     }


}
