using UnityEngine;
using System.Collections;


public class moveDoor : MonoBehaviour {

	public Vector3 endPos;
	public float speed = 1.0f;

	private bool moving = false;
	private bool opening = true;

	private Vector3 startPos;
	private float delay = 0.0f;

	public AudioSource source;
	public AudioClip clip;

	// Use this for initialization
	void Start()
	{
		startPos = transform.position;
	}

	// Update is called once per frame
	void Update()
	{
		if (moving)
		{
			if (opening)
			{
				MoveDoor(endPos);
				
			}
		}
	}

	void MoveDoor(Vector3 goalPos)
	{
		float dist = Vector3.Distance(transform.position, goalPos);
		if (dist > 0.1f)
		{
			transform.position = Vector3.Lerp(transform.position, goalPos, speed * Time.deltaTime);
			source.PlayOneShot(clip);
		}
		else
		{
			if (opening)
			{
				delay += Time.deltaTime;
				if (delay > 1.5f)
				{
					opening = false;
				}
			}
			else
			{
				moving = false;
				opening = true;
			}
		}
	}
	public bool Moving
	{
		get { return moving; }
		set { moving = value; }

	}
}
