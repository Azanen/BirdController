using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionZone : MonoBehaviour
{
    const float detectionRadius = 0.2f;
    public LayerMask checkPointZone;
    public Transform CPDetectionPoint; // CP = checkpoint
    public Transform spawnPoint;
    public GameObject crystalToSpawn;

    

    private void Update()
    {
        if (DetectCheckPointZone())
        {
            if (InteractInput())
            {
                Debug.Log("A crystal appears");
                Instantiate(crystalToSpawn, spawnPoint.position, spawnPoint.rotation);
            }
        }
    }

    bool InteractInput()
    {
        return Input.GetKeyDown(KeyCode.Q);
    }

    bool DetectCheckPointZone()
    {
        Vector3 Pos = CPDetectionPoint.position;
        Collider[] hitColliders = Physics.OverlapSphere(Pos, detectionRadius, checkPointZone);
        if (hitColliders.Length > 0)
        {
            return true;
        }

        return false;

    }
}
