using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private float length, startpost;
    public GameObject cam;
    public float parallaxEffect;

    void Start()
    {
        startpost = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void FixedUpdate()
    {
        float temp = (cam.transform.position.x * (1 - parallaxEffect));
        float dist = (cam.transform.position.x * parallaxEffect);
        transform.position = new Vector3(startpost + dist, transform.position.y, transform.position.z);

        if (temp > startpost + length) startpost += length;
        else if (temp < startpost - length) startpost -= length;
    }
}
