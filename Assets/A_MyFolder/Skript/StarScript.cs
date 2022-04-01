using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StarFall());
    }

    IEnumerator StarFall()
    {
        yield return new WaitForSeconds(1f);
        transform.position = new Vector3(85,34,49) ;
    }
}
