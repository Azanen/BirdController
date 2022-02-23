using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustDevilAscenseur : MonoBehaviour
{
    private Rigidbody quiMonte;
    public float hauteur;

    

    //donne une velocite verticale
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            quiMonte = other.GetComponent<Rigidbody>();
            quiMonte.velocity = Vector3.up * 8f;
        }
    }

    //desactive la gravite pour que eviter conflit avec vector3 up
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            quiMonte.useGravity = false;
            quiMonte.AddForce(transform.up * 2f);

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            quiMonte.useGravity = true;
        }
    }
}
