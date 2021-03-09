using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    //private AudioSource _audio;
    [SerializeField]
    private AudioClip _coinPickup;



    //private void OnTriggerStay(Collider other)
    //{

    //    Player playerRef = other.GetComponent<Player>();
    //    if (playerRef)
    //    {
    //        Debug.Log("AAAAAAAAAAAAAAAAAAA");
    //        if (Input.GetKeyDown(KeyCode.E))
    //        {
    //            playerRef.hasCoin = true;
    //            AudioSource.PlayClipAtPoint(_coinPickup, this.transform.position, 1f);
    //            Destroy(this.gameObject);
    //        }
    //    }
    //}

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Player player = other.GetComponent<Player>();
                if (player != null)
                {
                    player.hasCoin = true;
                    AudioSource.PlayClipAtPoint(_coinPickup, this.transform.position, 1f);
                    UIManager uIManager = GameObject.Find("Canvas").GetComponent<UIManager>();

                    if (uIManager)
                    {
                        uIManager.CollectedCoin();
                    }

                    Destroy(this.gameObject);
                }
            }
        }
    }
}
