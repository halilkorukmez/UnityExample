using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public GameObject target;
    public Vector3 cameraoffset;
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = target.transform.position+ cameraoffset;
    }
}
