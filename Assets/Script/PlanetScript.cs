using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetScript : MonoBehaviour
{
    
    void Start()
    {
        StartCoroutine(PlanetAlphaDelay(this.gameObject)); 
    }

    IEnumerator PlanetAlphaDelay(GameObject planetToAlphaGradient)
    {
        float PlanetAlphaValue = 0;
        Color PlanetColor;

        while (PlanetAlphaValue < 1)
        {
            PlanetAlphaValue+=0.025f;
            PlanetColor = new Color(0, 0.8f, 0.9f, PlanetAlphaValue);

            planetToAlphaGradient.GetComponent<Renderer>().material.color = PlanetColor;

            yield return new WaitForSeconds(0.2f);
        }
    }
}
