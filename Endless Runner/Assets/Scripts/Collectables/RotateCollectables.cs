using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCollectables : MonoBehaviour
{
    public float rotationSpeed = 3f;
    void Update()
    {
        transform.Rotate(0, rotationSpeed, 0, Space.World);
    }
    void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<AudioManager>().Play("Coin_Sound");
        this.gameObject.SetActive(false);
    }
}
