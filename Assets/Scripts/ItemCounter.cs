using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCounter : MonoBehaviour
{
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject itemToActive;
    public GameObject keyToActive;
    public GameObject dialogBox;
    
    public Text dialogText;
    public string dialog;
    private bool playerInRange;
    private bool itemPicked;

    private void Update()
    {
        if (Input.GetButtonUp("attack") && playerInRange)
        {
            if (dialogBox.activeInHierarchy)
            {
                dialogBox.SetActive(false);
                this.gameObject.SetActive(false);
                
            }
            else
            {
                itemPicked = true;
                dialogBox.SetActive(true);
                dialogText.text = dialog;
                itemToActive.SetActive(true);
                keyToActive.SetActive(true);
                enemy1.SetActive(true);
                enemy2.SetActive(true);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerInRange = true;
            
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerInRange = false;
            dialogBox.SetActive(false);
            if(itemPicked)
            {
                this.gameObject.SetActive(false);
            }
        }
    }

}
