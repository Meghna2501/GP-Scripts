using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioSource bgm;
    public AudioSource jmp;

    void Start()
    {
        bgm = GetComponent<AudioSource>();
        bgm.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
