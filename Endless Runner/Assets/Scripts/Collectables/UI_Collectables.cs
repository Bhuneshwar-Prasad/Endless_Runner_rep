using UnityEngine;
using UnityEngine.UI;

public class UI_Collectables : MonoBehaviour
{
    public Text CoinText;

    // Update is called once per frame
    void Update()
    {
        CoinText.text = RotateCollectables.totalCoins.ToString();
    }
}
