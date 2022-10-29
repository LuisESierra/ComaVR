using UnityEngine;
using System.Collections;

public class movimiento : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 direccion = new Vector3(Camera.main.transform.forward.x, 0, Camera.main.transform.forward.z);

        if (Input.GetKey(KeyCode.Q)) { transform.Translate(direccion * Time.deltaTime * 5, Space.World); }

		if (Input.GetKey(KeyCode.S)) { transform.Translate(direccion * -1  * Time.deltaTime * 5, Space.World); }

		//transform.Translate(Vector3.forward * 20, Space.Self);


	}
}
