using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinalDialog : MonoBehaviour
{
    public FloatValue bossHP;
    public GameObject dialogBox;
    public Text dialogText;
    public string dialog;

    private void Update()
    {
        if(bossHP.RuntimeValue == 0)
        {
            dialogBox.SetActive(true);
            dialogText.text = dialog;

            if (Input.GetKeyUp(KeyCode.Space))
            {
                SceneManager.LoadScene("Menu");
            }
        }
    }
}
