using System.Collections;
using System.Collections.Generic;
using System.Timers;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public float time = 50f;
    public bool countDonwnOn = true;
    void Start()
    {
        StartCoroutine(timer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     IEnumerator timer()
        {
            while (time>0)
            {
                time--;
                GetComponent<TextMeshProUGUI>().text = "" + time;
                yield return new WaitForSeconds(1f);
            }
        }
     private void OnTriggerEnter(Collider other)
     {
         if (other.gameObject.CompareTag("Miam"))
         {
             // _scoreValue= _scoreValue+ 10;
             // scoreText.text = "temps restant : " + _scoreValue;
            
         } 
     }
}

