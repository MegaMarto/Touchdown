using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeyserExpansion : MonoBehaviour
{
    public GameObject puddle;

    public float timer = 0f;
    public float growTime = 50f;
    public float maxSize = 400f;

    public bool isMaxSize = false;
    void Start()
    {
        if (isMaxSize == false)
        {
            StartCoroutine(Grow());
        }
    }


    private IEnumerator Grow()
    {
        Vector3 startScale = transform.localScale;
        Vector3 maxScale = new Vector3(2, maxSize, 2);

        do
        {
            transform.localScale = Vector3.Lerp(startScale, maxScale, timer / growTime);
            timer += Time.deltaTime;
            yield return null;
        }
        while (timer < growTime);

        isMaxSize = true;

        if (isMaxSize = true)
        {
            Destroy(puddle);
        }
    }
}
