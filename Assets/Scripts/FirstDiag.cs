using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstDiag : MonoBehaviour
{
    public GameObject dialogBox;
    public Text dialogText;
    public string dialog;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        dialogBox.SetActive(true);
        dialogText.text = dialog;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        dialogBox.SetActive(false);
        this.gameObject.SetActive(false);
    }
}
