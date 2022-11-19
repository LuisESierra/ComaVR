using UnityEngine;
using System.Collections;

public class detectDoorCollition : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private void OnTriggerStay(Collider col)
    {
		if (col.tag == "Door")
        {
			if (col.GetComponent<Slide>().Moving == false)
            {
				col.GetComponent<Slide>().Moving = true;

			}
        }
    }
}
