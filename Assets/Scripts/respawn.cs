﻿using UnityEngine;
using System.Collections;

public class respawn : MonoBehaviour
{
    public float threshold;

    void FixedUpdate()
    {
        if (transform.position.y < threshold)
            transform.position = new Vector3(-4, 1, 1);
    }
}