using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionZone : MonoBehaviour
{
    public Transform detectionPoint;
    const float detectionRadius = 0.2f;
    public LayerMask checkPointZone;

    private void Update()
    {
        if (DetectCheckPointZone())
        {
            if (InteractInput())
            {
                Debug.Log("Interact!");
            }
        }
    }

    bool InteractInput()
    {
        return Input.GetKeyDown(KeyCode.Q);
    }

    bool DetectCheckPointZone()
    {
        Vector3 Pos = detectionPoint.position;
        Collider[] hitColliders = Physics.OverlapSphere(Pos, detectionRadius, checkPointZone);
        if (hitColliders.Length > 0)
        {
            return true;
        }

        return false;

    }
}
