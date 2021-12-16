using UnityEngine.Audio;
using System;
using UnityEngine;

public class BGM : MonoBehaviour
{
    public AudioSource audioSource;
    private float fixedDeltaTime;
    // Start is called before the first frame update
    void Start()
    {
       audioSource = GetComponent<AudioSource>();
       this.fixedDeltaTime = Time.fixedDeltaTime;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
