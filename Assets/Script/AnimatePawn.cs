using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatePawn : MonoBehaviour
{
    public GameObject pawn_1;
    public GameObject pawn_2;

    private Vector3 position1;
    private Vector3 position2;
    void Start()
    {
        //pawn_2.GetComponent<MeshRenderer>().enabled = false;
        position1 = pawn_1.GetComponent<Transform>().position;
        position2 = pawn_2.GetComponent<Transform>().position;
    }

    void Update()
    {
        pawn_1.transform.position = Vector3.Lerp(position1, position2, ((Mathf.Sin(Time.time)+1.0f)/2.0f));
        pawn_2.transform.position = Vector3.Lerp(position1, position2, ((Mathf.Sin(Time.time + (float)Math.PI)+1.0f)/2.0f));
    }
}
