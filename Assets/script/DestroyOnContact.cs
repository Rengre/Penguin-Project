using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnContact : MonoBehaviour
{
    public GameObject restartButton;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag != "water")
        {
            Destroy(other.gameObject);
        }
    }
}

