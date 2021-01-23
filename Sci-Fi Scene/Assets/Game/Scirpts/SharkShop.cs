using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkShop : MonoBehaviour
{
    private AudioSource _audio;
    void Start()
    {
        _audio = GetComponent<AudioSource>();
    }
    
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Player player = other.GetComponent<Player>();
                
                if (player != null)
                {
                    if (player.hasCoin == true)
                    {
                        player.hasCoin = false;
                        UIManager uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();
                        if (uiManager != null)
                        {
                            uiManager.RemoveCoin();
                        }

                        _audio.Play();
                        player.EnableWeapons();
                    }
                    else
                    {
                        Debug.Log("Get out of here!");
                    }
                }
            }
        }
    }
}
