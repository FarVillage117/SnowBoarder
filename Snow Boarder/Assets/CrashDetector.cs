using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashDetector : MonoBehaviour
{
    void OnTriggerEnter2D(Collision2D other)
    {
        if(other.tag == "Ground")
        {
            Debug.Log("Ouch");
        }
    }
}
