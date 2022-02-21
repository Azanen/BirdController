using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brisable : MonoBehaviour
{
    public bool isDashing;
    public GameObject particule;
    public AudioSource bedingbedang;

    private void Start()
    {
        particule.SetActive(false);
        bedingbedang = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isDashing = other.GetComponent<isDashing>().dashing;

            if (isDashing == true)
            {
                StartCoroutine(Brise());
            }
        }
    }

    IEnumerator Brise()
    {
        bedingbedang.Play();
        particule.SetActive(true);
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<BoxCollider>().enabled = false;
        yield return new WaitForSeconds(1.3f);
        Destroy(transform.parent.gameObject);
        Destroy(particule);
        Destroy(this.gameObject);
    }

}
