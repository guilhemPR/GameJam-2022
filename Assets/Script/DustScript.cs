using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustScript : MonoBehaviour
{

    void Start()
    {
        
        
        StartCoroutine(DustLifeTime());
    }

    IEnumerator DustLifeTime()
    {
        
        
        float lifeTimer = Random.Range(10, 1);

        yield return new WaitForSeconds(lifeTimer); 
        
        Debug.Log("bidul");
        
        Destroy(this.gameObject);
        
        
    }
}
