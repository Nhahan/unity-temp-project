using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Hello");
    }

    public void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Event") {
            Destroy(other.gameObject, 0.05f);
        }
    }
}