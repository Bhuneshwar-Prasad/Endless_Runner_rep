using UnityEngine;

public class character_movement : MonoBehaviour
{
    public float player_speed = 3f;
    float horizontal_speed = 3.5f;

    void Start()
    {
        FindObjectOfType<AudioManager>().Play("BGM");
    }
    void Update()
    {
        transform.Translate(Vector3.forward * player_speed * Time.deltaTime, Space.World);

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * horizontal_speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.left * horizontal_speed * -1 * Time.deltaTime);
        }
    }
}
