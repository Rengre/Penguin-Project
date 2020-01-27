using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    Material material;
    Vector2 offset;
    public float speedX;
    int speedY = 0;
    private void Awake()
    {
        material = GetComponent<Renderer>().material;
    }
    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector2(speedX, speedY);
      //  Shadows2DDN.Handler.AddShadow(transform);
    }

    // Update is called once per frame
    void Update()
    {
       
        material.mainTextureOffset += offset* Time.deltaTime;
    }
}
