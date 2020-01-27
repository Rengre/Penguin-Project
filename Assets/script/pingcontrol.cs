using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pingcontrol : MonoBehaviour
{
    public Transform player;
    public float speed = 5.0f;
    public Rigidbody2D rb;
    Vector2 movement;
    public Vector2 m;
    public Camera cam;
    private float maxHeight;
    public GameObject GameOverText;
    public Animator animator;
    public AudioSource hitsource;
    public AudioSource deadsource;

    void Start()
    {
          rb = GetComponent<Rigidbody2D>();       
    }
    void Update()
    {
        {
           movement.y = Input.GetAxisRaw("Vertical");
            animator.SetFloat("vertical",movement.y);
            animator.SetFloat("speed", movement.sqrMagnitude);
            m.y = 0.1f;
        }
    }
      void FixedUpdate()
        {
           if (player.position.y >= -10 && player.position.y <= 3)
               rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
           else
           {
               if (player.position.y >= 3)
                   rb.MovePosition(rb.position - m);
               if (player.position.y <= -10)
                   rb.MovePosition(rb.position + m);
           }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Orca" )
        {
            deadsource.Play();
            Destroy(this.gameObject);
            GameOverText.SetActive(true);
            
            
        }
        else if (other.gameObject.tag == "landscape")
        {
            hitsource.Play();
            this.GetComponent<score>().Score -= 3;
            this.GetComponent<score>().scoreText.text = "Score:\n" + this.GetComponent<score>().Score;
            
        }
    }

}
