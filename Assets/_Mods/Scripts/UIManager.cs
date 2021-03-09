using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text ammoText;

    public GameObject coin;


    public void UpdateAmmo(int count)
    {
        ammoText.text = "Ammo: " + count;
    }


    public void CollectedCoin()
    {
        coin.SetActive(true);
    }
}
