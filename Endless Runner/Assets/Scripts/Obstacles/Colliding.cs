using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colliding : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<character_movement>().enabled = false;
        other.gameObject.GetComponentInChildren<Animator>().Play("Stumble Backwards");
        Debug.Log(gameObject + " has been collided");
    }
}
