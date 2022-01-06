using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe_move : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //deplace la prefab sur la gauche avec une vitesse donné sur le temps interne du jeu
        transform.position += Vector3.left * speed * Time.deltaTime;    
    }
}
