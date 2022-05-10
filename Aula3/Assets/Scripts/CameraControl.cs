using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow)) {
            transform.position = transform.position + new Vector3(-0.1f, 0, 0);
        }
        transform.LookAt(target);
    }
}
