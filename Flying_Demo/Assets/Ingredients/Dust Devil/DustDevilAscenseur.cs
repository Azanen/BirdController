using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustDevilAscenseur : MonoBehaviour
{
    //private Rigidbody quiMonte;
    public float hauteur;

    private PlayerCollisionSphere quiMonte;
    private Rigidbody quiMonteRigid;

    //donne une velocite verticale
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            quiMonte = other.GetComponent<PlayerCollisionSphere>();
            quiMonteRigid = quiMonte.GetComponent<Rigidbody>();
            quiMonteRigid.velocity = Vector3.up * 8f;
        }
    }

    //desactive la gravite pour que eviter conflit avec vector3 up
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            quiMonteRigid.useGravity = false;
            quiMonteRigid.AddForce(transform.up * 2f);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            quiMonteRigid.useGravity = true;
        }
    }
}
