using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saturn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(new Vector3(0, Time.deltaTime * 45f, 0));
        transform.RotateAround(Vector3.zero, Vector3.up, Time.deltaTime * 7f);
    }
}
