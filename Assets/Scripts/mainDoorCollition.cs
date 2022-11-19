using UnityEngine;
using System.Collections;

public class mainDoorCollition : MonoBehaviour {

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

	private void OnTriggerStay(Collider col)
	{
		if (col.tag == "Door")
		{
			if (col.GetComponent<moveDoor>().Moving == false)
			{
				col.GetComponent<moveDoor>().Moving = true;

			}
		}
	}
}
