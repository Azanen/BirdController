using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    public Vector3 respawnPoint;
    public GameObject deathzone;
    private void update()
    {
        deathzone.transform.position = new Vector3 (transform.position.x, deathzone.transform.position.y, transform.position.z);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.transform.gameObject.tag == "Player")
        {
            other.transform.position = respawnPoint;
        }
    }
}

//public class deathzone : monobehaviour
//{
//    private vector3 respawnpoint;
//    public gameobject deathzone;
//    private void update()
//    {
//        deathzone.transform.position = new vector3(transform.position.x, deathzone.transform.position.y, transform.position.z);
//    }
//    void ontriggerenter(collider other)
//    {
//        if (other.transform.gameobject.tag == "player")
//        {
//            other.transform.position = respawnpoint;
//        }
//    }
//}