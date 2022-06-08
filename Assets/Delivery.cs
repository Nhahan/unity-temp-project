using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Hello");
    }

    public void OnTriggerEnter2D(Collision2D other) {
        if (other.tag == "Event") {
            Debug.Log("Event Occured")
        }
    }
}
