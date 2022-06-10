using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    void private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("You Finished!");
    }
}
