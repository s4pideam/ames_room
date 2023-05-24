using System;
using UnityEngine;

public class AnimateCamera : MonoBehaviour
{
    public Camera cam;
    public Transform cameraPath;

    private bool forward;
    private bool animate;
    private int index;
    private Transform target;
    void Start()
    {
        forward = false;
        animate = false;
        index = 0;
    }
    
    void Update()
    {
        if (!isActiveAndEnabled) return;
        if (Input.GetKeyDown("space"))
        {
            animate = true;
            forward = !forward;
            if (forward)index++;
            if (!forward) index--;
            index = Math.Max(Math.Min(cameraPath.childCount - 1, index), 0);
            
        }

        if (!animate) return;
        target = cameraPath.GetChild (index);
        cam.transform.position = Vector3.MoveTowards (cam.transform.position, target.position,  Time.deltaTime);
        if (Vector3.Distance(cam.transform.position, target.position) < 0.1f)
        {
            if (forward)
            {
                index++;
                if (index > cameraPath.childCount -1)
                {
                    index = cameraPath.childCount - 1;
                    animate = false;
                }
            }
            else
            {
                index--;
                if (index < 0)
                {
                    index = 0;
                    animate = false;
                }
            }

        }
    }
    
    void OnDisable()
    {
        index = 0;
        animate = false;
        target = cameraPath.GetChild (index);
        cam.transform.position = target.position;
    }
    
    void OnEnable()
    {
        forward = false;
        animate = false;
        index = 0;
    }
}
