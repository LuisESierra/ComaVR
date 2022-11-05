using UnityEngine;
using System.Collections;

public class obtenerObjeto : MonoBehaviour {

	GameObject generador;

	public crearObjetos scriptLlamado;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "generador")
        {

            scriptLlamado.numObjetos++;

            Debug.Log("Codigo obtener objeto aqui");
            //Debug.Log("DETECTO " + scriptLlamado.numObjetos);
            Destroy(collision.gameObject);
            //script.numObjetos++;

            //Debug.Log("DETECTO " + scriptLlamado.numObjetos);
        }

        //generadorActivo.gameObject.tag="nulo";
    }



}
