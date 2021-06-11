using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Boss : GhostEnemy
{
    public FloatValue bossHP;
    public GameObject dialogBox;
    public Text dialogText;
    public string dialog;
    public GameObject ObjectToActivate;

    private void Update()
    {
        if (health <= 0)
        {
            dialogBox.SetActive(true);
            dialogText.text = dialog;
            ObjectToActivate.SetActive(true);
        }
    }
    

}
