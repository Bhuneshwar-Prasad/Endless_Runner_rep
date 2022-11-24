using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float player_speed = 3f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * player_speed * Time.deltaTime, Space.World);
    }
}
