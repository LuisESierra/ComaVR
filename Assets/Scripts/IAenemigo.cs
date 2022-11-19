using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.AI;


public class IAenemigo : MonoBehaviour
{
    // Start is called before the first frame update
    //https://www.youtube.com/watch?v=36dht94VsDI&ab_channel=VionixStudio
    //guia

    //declarando enemigo como agente del mesh
    NavMeshAgent enemy;
    //declaro el jugador a buscar
    public GameObject Player;
    //generador ruido
    GameObject ruido;

    void Start()
    {
        //pidiendo los componentes
        enemy = GetComponent<NavMeshAgent>();
        //le decimos que el jugador es el que lleve esa tag
        //ruido = GameObject.FindWithTag("generadorRuido");
    }

    // Update is called once per frame
    void Update()
    {
        //comando simple para que lo siga
        //que el enemigo tenga como destino
        //la posicion actual del jugador
        //enemy.SetDestination(player.transform.position);

        //ahora tendremos un if, en el cual el persigue con mayor prioridad
        //los generadores de ruido

        try
        {
            ruido = GameObject.FindGameObjectWithTag("generadorRuido");
            //if(script.dist < 1000) { 
            enemy.SetDestination(ruido.transform.position);
            //}

        }
        catch (Exception e) {

            enemy.SetDestination(Player.transform.position); 
        }


        //ruido = GameObject.FindWithTag("generadorRuido");

        //if (ruido.gameObject.activeInHierarchy)
        //{
        //    enemy.SetDestination(ruido.transform.position);
        //}
        //else { enemy.SetDestination(player.transform.position); }



    }
}