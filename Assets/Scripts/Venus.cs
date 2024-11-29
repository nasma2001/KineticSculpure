using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Venus : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(new Vector3(0, Time.deltaTime * 1.5f, 0));
        transform.RotateAround(Vector3.zero, Vector3.up, Time.deltaTime * 30f);
    }
}
