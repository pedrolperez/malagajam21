using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossActivator : MonoBehaviour
{
    public GameObject boss;
    public GameObject dialogBox;
    public GameObject healthHolder;
    public Text dialogText;
    public string dialog;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        boss.SetActive(true);
        healthHolder.SetActive(true);
        dialogBox.SetActive(true);
        dialogText.text = dialog;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        dialogBox.SetActive(false);
        this.gameObject.SetActive(false);
    }
}

