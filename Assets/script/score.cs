using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour
{
    public Text scoreText;
    public int pinValue;   
    public int Score;
    public AudioSource ticksource;
    void Start()
    {
        Score = 0;
        scoreText.text = "Score:\n" + Score;
        ticksource = GetComponent<AudioSource>();
       
    }
    private void OnTriggerEnter2D(Collider2D other)
    {


        if (other.gameObject.tag == "fish")
        {
            Score += 1;
            scoreText.text = "Score:\n" + Score;
            Destroy(other.gameObject);
            ticksource.Play();

        }

    }
}
