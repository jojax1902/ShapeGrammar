using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        GameObject table = this.gameObject;
        table.transform.Rotate((Vector3.up * .05f));
    }
}
