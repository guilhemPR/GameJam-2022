using System;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public delegate void InputAction();

    public static event InputAction up; 
    
    
    private float time = 0f;
    private float timeEnd = 60f; 
    public bool countDonwnOn = true;
    public string LevelToLoad;


    void Start()
    {
        StartCoroutine(timer());
    }

    IEnumerator timer()
        {
            while (time<timeEnd)
            {
                time++;
                if (time >= timeEnd)
                {
                  up?.Invoke();
                  SceneManager.LoadScene(LevelToLoad);
                }
                
                yield return new WaitForSeconds(1f);
            }
        }
        
     
  
}

