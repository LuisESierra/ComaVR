using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Colisiones : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject player;
    GameObject generadorActivo;
    GameObject enemigo;

    public float dist;


    void Start()
    //este codigo define las colisiones del enemigo
    //es decir con jugador game over
    //y con generadores de ruido que los destruye

    {
        player = GameObject.FindGameObjectWithTag("Player");
        //generadorActivo = GameObject.FindWithTag("generadorRuido");

        enemigo = GameObject.FindGameObjectWithTag("enemigo");
        generadorActivo = GameObject.FindGameObjectWithTag("generadorRuido");

    }

    // Update is called once per frame
    void Update()
    {
        generadorActivo = GameObject.FindGameObjectWithTag("generadorRuido");


    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player") { 
            SceneManager.LoadScene(2); 
        }
        if (collision.gameObject.tag == "generadorRuido") { Debug.Log("destruido"); Destroy(collision.gameObject); }
        //generadorActivo.gameObject.tag="nulo";
    }

}
