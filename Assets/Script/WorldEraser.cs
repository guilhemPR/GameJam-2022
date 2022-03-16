using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldEraser : MonoBehaviour
{
    // ----- Variable of worldEraser ----- //


    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
