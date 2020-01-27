using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour
{
    public AudioClip musicclip;
    public AudioSource musicsource;
    // Start is called before the first frame update
    void Start()
    {
        musicsource.clip = musicclip;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (musicsource.isPlaying)
             musicsource.Pause();
            else
                // if (Input.GetKeyDown(KeyCode.x))
                musicsource.Play();
        }
    }
}
