using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavour : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        StartCoroutine(DestroyButtel());
    }
    IEnumerator DestroyButtel()
    {
        yield return new WaitForSeconds(3.5f);

        Destroy(gameObject);
    }
}
