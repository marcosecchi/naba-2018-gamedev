﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotator : MonoBehaviour {

    public float speed = 10f;

	void Update ()
    {
        transform.Rotate(Vector3.up, speed);	
	}
}