using UnityEngine;
using UnityEngine.UI;

public class ObjectCounter : MonoBehaviour
{
    // Counter to store the number of objects in the area
    public int objectCount = 0;
    [SerializeField] private Text _text;
    // Called when a collider enters the trigger area
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the entering collider is a game object you want to count
        if (other.CompareTag("Fly"))
        {
            // Increment the object count
            objectCount++;
        }
    }

    // Called when a collider exits the trigger area
    private void OnTriggerExit2D(Collider2D other)
    {
        // Check if the exiting collider is a game object you want to count
        if (other.CompareTag("Fly"))
        {
            // Decrement the object count
            objectCount--;
        }
    }

    private void FixedUpdate() {
        _text.text = objectCount.ToString();
    }
}