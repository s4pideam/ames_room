using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateY : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isActiveAndEnabled) return;
        transform.Rotate(0,(200*Time.deltaTime%360),0);
    }
}
