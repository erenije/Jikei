using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public Transform CameraTransform;
    public float parallaxEffect;
    
    private float length;
    private float startPos;

    private void Start()
    {
        startPos = transform.localPosition.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    private void FixedUpdate()
    {
        float temp = CameraTransform.position.x * (1 + parallaxEffect);
        float distance = CameraTransform.position.x * parallaxEffect;
        transform.localPosition = new Vector3(startPos + distance, transform.localPosition.y, transform.localPosition.z);

        if (temp > startPos + length) startPos += length;
        else if (temp < startPos - length) startPos -= length;
    }
}
