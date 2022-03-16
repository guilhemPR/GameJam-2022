using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Jouer()
    {
        SceneManager.LoadScene("SampleScene 1");
        
    }
    
    
    public void Resultat()
    {
        SceneManager.LoadScene("Score");
        
    }
    
    public void Retour()
    {
        SceneManager.LoadScene("Menu");
        
    }

    
    
}
