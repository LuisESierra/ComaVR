using UnityEngine;
using System.Collections;

public class animationScript : MonoBehaviour {
	Animator animator;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		bool isWalking = animator.GetBool("isWalking");
		bool isBackwarding = animator.GetBool("isBackwarding");

		bool fowardPressed = Input.GetKey("w");
		bool backwardPressed = Input.GetKey("s");

		if (!isWalking && fowardPressed)
        {
			animator.SetBool("isWalking", true);
        }
		if (isWalking && !fowardPressed)
		{
			animator.SetBool("isWalking", false);
		}
		if (!isBackwarding && backwardPressed)
		{
			animator.SetBool("isBackwarding", true);
		}
		if (isBackwarding && !backwardPressed)
		{
			animator.SetBool("isBackwarding", false);
		}

	}
}
