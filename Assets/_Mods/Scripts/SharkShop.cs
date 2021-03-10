using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkShop : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Player player = other.GetComponent<Player>();
                if (player)
                {
                    if (player.hasCoin)
                    {
                        player.hasCoin = false;
                        UIManager uIManager = GameObject.Find("Canvas").GetComponent<UIManager>();
                        if (uIManager)
                        {
                            uIManager.RemoveCoin();
                        }

                        AudioSource audio = GetComponent<AudioSource>();
                        audio.Play();
                        player.EnableWeapons();
                    }
                    else
                    {
                        Debug.Log("No Coin, Pal!");
                    }
                }
            }
        }
    }
}
