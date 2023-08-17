using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlueProjectileLife : MonoBehaviour
{
    public GameObject Glue;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SelfDestruct());
    }

    IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(2.5f);
        Destroy(Glue);
    }
}
