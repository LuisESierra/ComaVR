using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crearObjetos : MonoBehaviour
{
    // Start is called before the first frame update

    //parametros de instancia

    public Object objeto;

    public int numObjetos;

    public Transform Jugador;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse2) && numObjetos > 0)
        {
            Debug.Log("se presionó w");
            Instantiate(objeto, Jugador.position, Quaternion.identity);
            numObjetos--;
        }
    }



    //void crear()
    //{
    //    GameObject objToSpawn;

    //    //spawn object
    //    objToSpawn = new GameObject("Cool GameObject made from Code");
    //    //Add Components
    //    objToSpawn.AddComponent<Rigidbody>();
    //    objToSpawn.AddComponent<MeshFilter>();
    //    objToSpawn.AddComponent<BoxCollider>();
    //    objToSpawn.AddComponent<MeshRenderer>();
    //}


}
