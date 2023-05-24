using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomChooser : MonoBehaviour
{
    private int index = 0;
    private int count = 0;
    void Start()
    {
        count = transform.childCount;
        for (int i = 0; i <= count -1; i++)
        {
            transform.GetChild(i).gameObject.SetActive(false);
        }
        transform.GetChild(index).gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("left"))
        {
            transform.GetChild(index).gameObject.SetActive(false);
            index--;
            index = Math.Abs(index % count);
            transform.GetChild(index).gameObject.SetActive(true);
        }
        if (Input.GetKeyDown("right"))
        {
            transform.GetChild(index).gameObject.SetActive(false);
            index++;
            index =  Math.Abs(index % count);
            transform.GetChild(index).gameObject.SetActive(true);
        }
    }
}
