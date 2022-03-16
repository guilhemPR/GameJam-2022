using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Jobs;
using UnityEngine.UI;

public class Joueur : MonoBehaviour
{
    public float speed = 0.005f;
    public float flySpeed = 0.5f;
    public float minPos = -3.75f;
    public float maxPos = 3.75f;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI scoretime;
    private int _scoreValue;
    
   


    private float BoostSpeed = 0.1f;
    private int BoostTime = 15;
    
    
    private void Update()
    {
        /*if (Input.GetAxis("Horizontal") != 0)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y,
                Mathf.Clamp(transform.position.z + Input.GetAxis("Horizontal") * speed, minPos, maxPos));
            
            
        }*/
        if (Input.GetKey(KeyCode.RightArrow) && transform.position.z < maxPos)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y,transform.position.z + speed*Time.deltaTime);
           
            if (transform.rotation.z < 40)
            {
                transform.Rotate(0,0.1f, 0);
            }
        }
        else if (Input.GetKey(KeyCode.LeftArrow) && transform.position.z > minPos)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z -speed*Time.deltaTime);
            if (transform.rotation.z > -40)
            {
                transform.Rotate(0,-0.1f, 0);
            }
        }
        else if (transform.rotation.y != 0)
        {
            if (transform.rotation.y>0)
            {
                transform.Rotate(0, -0.1f, 0);
            }
            if (transform.rotation.y<0)
            {
                transform.Rotate(0,0.1f, 0);
            }
        }
        
        

        if (Input.GetKey(KeyCode.Space) && BoostTime>0)
        {
            transform.position += transform.up * (flySpeed + BoostSpeed)*Time.deltaTime;
            StartCoroutine(SpeedBoostIncrease());

     
        }
        else
        {
            transform.position = new Vector3(transform.position.x - flySpeed*Time.deltaTime, transform.position.y, transform.position.z);
            
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Miam"))
        {
           // _scoreValue= _scoreValue+ 10;
           // scoreText.text = "temps restant : " + _scoreValue;
            _scoreValue++;
            scoreText.text = "Score : " + _scoreValue;
            Destroy((other.gameObject));
        } 
    }

    private IEnumerator SpeedBoostIncrease()
    {
        if (BoostTime>13)
        {
             BoostSpeed += 0.5f; 
             Debug.Log("boost");
        }
        else if (BoostTime>8)
        {
            BoostSpeed += 1f;
        }
        else if (BoostTime>5)
        {
            BoostSpeed += 1.5f;
        }
    
        BoostTime--;
        Debug.Log(BoostSpeed);
        
        yield return new WaitForSeconds(1f); 
    } 

}
