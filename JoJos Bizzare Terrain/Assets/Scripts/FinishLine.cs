using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FinishLine : MonoBehaviour
{
    public UnityEvent finished;
    public bool hasFinished = false;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (hasFinished == false)
            {
                finished.Invoke();

                hasFinished = true;
            }
        }
    }
}
