using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pit : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //GameObject scgo = GameObject.Find("SceneController");
            //SceneController sc = scgo.GetComponent<SceneController>();

            SceneController sc = FindObjectOfType<SceneController>();

            sc.Reload();
        }
    }
}
