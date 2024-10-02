using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    private Quaternion resetRotation;  // The rotation to reset the platform to
    public float resetDelay = 3f;      // Delay before resetting the platform (3 seconds)

    void Start()
    {
        // Store the initial rotation of the platform at the start of the game
        resetRotation = transform.rotation;
        Debug.Log("Initial reset rotation: " + resetRotation);  // Log the initial rotation
    }

    // Detect when another object enters the trigger zone
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Something entered the trigger zone");  // Check if anything is entering the trigger

        // Check if the object that collided is the player
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entered the trigger zone");  // Log to confirm collision with the player
            // Invoke the ResetPlatformRotation method after a delay of resetDelay seconds
            Invoke("ResetPlatformRotation", resetDelay);
        }
    }

    // Method to reset the platform's rotation
    private void ResetPlatformRotation()
    {
        Debug.Log("Resetting platform to original rotation");  // Log to confirm reset
        // Reset the platform's rotation to its original rotation
        transform.rotation = resetRotation;
    }
}