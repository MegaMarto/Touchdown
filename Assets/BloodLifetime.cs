using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodLifetime : MonoBehaviour
{

    public GameObject blood;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SelfDestruct());
    }

    IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(blood);
    }
}
