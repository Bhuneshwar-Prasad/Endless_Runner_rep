using UnityEngine;
using UnityEngine.UI;

public class UI_Texts : MonoBehaviour
{
    public Text CoinText;
    public Text DistanceCovered;
    
    float distanceOffset = 22.65f;

    public Transform player;

    // Update is called once per frame

    void Start()
    {
        DistanceCovered.text = "0";
    }
    void Update()
    {
        CoinText.text = RotateCollectables.totalCoins.ToString();
        DistanceCovered.text = (distanceOffset+player.position.z).ToString("0");
        Debug.Log(player.position.z);
    }
}
