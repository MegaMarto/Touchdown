using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaplerBulletLife : MonoBehaviour
{
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SelfDestruct());
    }

    IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(3f);
        Destroy(bullet);
    }
}
