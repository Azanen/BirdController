using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class soul_collect : MonoBehaviour
{
    public AudioSource collectsound;

   private void OnTriggerEnter(Collider other)
    {
        collectsound.Play();
        Destroy(gameObject);
    }
}
