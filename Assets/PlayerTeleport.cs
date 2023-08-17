using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleport : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("RedPortal"))
        {
            transform.position = new Vector3(-55, 0, 176);
        }
        else if (other.gameObject.CompareTag("GreenPortal"))
        {
            transform.position = new Vector3(71, 0, 0);
        }
        else if (other.gameObject.CompareTag("BluePortal"))
        {
            transform.position = new Vector3(15, 58, -344);
        }
    }
}
