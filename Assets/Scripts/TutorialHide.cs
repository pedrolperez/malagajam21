using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialHide : TutorialScript
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        text.SetActive(false);
    }
}
