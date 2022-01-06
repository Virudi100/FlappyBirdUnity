using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fly_bird : MonoBehaviour
{
    public Gamemanager gameManager;
    public float velocity = 1;
    private Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        //Recupere le composent rigidbody 2d sur le Gameobject sur lequel il est appliqué
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //jump bird

            rb.velocity = Vector2.up * velocity;

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GameOver();
    }
}
