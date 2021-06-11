using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialScript : MonoBehaviour
{
    public string placeName;
    public GameObject text;
    public Text placeText;
    public float secondsToWait;
    private void OnTriggerEnter2D(Collider2D collision)
    {
            StartCoroutine(ShowText());
    }

    
    private IEnumerator ShowText()
    {
        text.SetActive(true);
        placeText.text = placeName;
        yield return new WaitForSeconds(secondsToWait);
        text.SetActive(false);

    }

}

