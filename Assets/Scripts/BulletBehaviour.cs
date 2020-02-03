﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    public Alignment Alignment;
    public float Range;
    public float Speed;
    public Vector3 Direction;

    float _distanceTravelled;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float incrementalDistance = Speed * Time.deltaTime;

        transform.position += Direction * incrementalDistance;
        _distanceTravelled += incrementalDistance;

        if (_distanceTravelled > Range)
        {
            Destroy(gameObject);
        }
    }
}