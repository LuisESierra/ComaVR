using UnityEngine;
using System.Collections;

public class destroyDoor : MonoBehaviour {

	public GameObject block;
	public GameObject alarm;
	private bool canDestroy;

	public AudioSource source;
	public AudioClip clip;

	// Use this for initialization
	void Start () {
		canDestroy = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (canDestroy == true)
		{
			source.PlayOneShot(clip);
			Destroy(block);
		}
	}

	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject == alarm)
		{
			canDestroy = true;
			Destroy(collision.gameObject);
		}

	}
}
