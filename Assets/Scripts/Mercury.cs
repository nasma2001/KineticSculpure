using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Manager : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(new Vector3(0, Time.deltaTime * 10, 0));
        transform.RotateAround(Vector3.zero, Vector3.up, Time.deltaTime * 35f);
    }
}
