using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{

    public AudioSource audio;
    private AudioSource audioSource;

    public AudioSource audioclose;
    private AudioSource audioSourceclose;

    public float x;
    private float howlong;
    void Start()
    {
        audioSourceclose = audioclose;
        audioSource = audio;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L) && Time.time > howlong)
        {
            howlong = Time.time + x;
            audioSourceclose.Stop();
            audioSource.Play();
            howlong = Time.time + x;
        }
        if (Input.GetKeyDown(KeyCode.L) && Time.time == howlong)
        {
            audioSourceclose.Play();
        }
    }
}