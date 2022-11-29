using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCollectables : MonoBehaviour
{
    public static int totalCoins = 0;
    public float rotationSpeed = 3f;
    void Update()
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0, Space.World);
    }
    void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<AudioManager>().Play("Coin_Sound");
        totalCoins += 1;
        this.gameObject.SetActive(false);
    }
}
