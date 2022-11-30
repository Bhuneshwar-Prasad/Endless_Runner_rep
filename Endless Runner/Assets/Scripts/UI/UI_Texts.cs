using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UI_Texts : MonoBehaviour
{
    public Text CoinText;
    public Text DistanceCovered;
    
    public float distanceOffset = 22.65f;

    public Transform player;

    public GameObject[] countdown;

    // Update is called once per frame

    void Start()
    {
        StartCoroutine(CountSequence());
    }

    IEnumerator CountSequence()
    {
        countdown[4].SetActive(true);
        yield return new WaitForSeconds(1.4f);

        FindObjectOfType<AudioManager>().Play("3");
        countdown[0].SetActive(true);
        yield return new WaitForSeconds(1.4f);

        FindObjectOfType<AudioManager>().Play("2");
        countdown[1].SetActive(true);
        yield return new WaitForSeconds(1.4f);

        FindObjectOfType<AudioManager>().Play("1");
        countdown[2].SetActive(true);
        yield return new WaitForSeconds(1.4f);

        FindObjectOfType<AudioManager>().Play("GO");
        countdown[3].SetActive(true);
        character_movement.ready = true;
        yield return new WaitForSeconds(2f);

        foreach (GameObject item in countdown) {
            item.SetActive(false);
        }
 
    }
    void Update()
    {
        CoinText.text = RotateCollectables.totalCoins.ToString();
        DistanceCovered.text = (distanceOffset+player.position.z).ToString("0");
    }

    
}
