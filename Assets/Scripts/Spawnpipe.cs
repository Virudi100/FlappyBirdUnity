using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnpipe : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public GameObject pipe;
    public float height;

    // Start is called before the first frame update
    void Start()
    {
        //Instancie un nouveau Gameobject de Tuyaux avec une hauteur Y aléatoire
        GameObject newpipe = Instantiate(pipe);
        newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height),0);
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > maxTime)
        {
            /*Instancie un nouveau Gameobject de Tuyaux avec une hauteur Y aléatoire 
            et utilise le timer pour les instanciers toujours à la meme distances l'un de l'autre */

            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height),0);
            Destroy(newpipe, 15);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
