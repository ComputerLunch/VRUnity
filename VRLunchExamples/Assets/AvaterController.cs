using UnityEngine;
using System.Collections;

public class AvaterController : MonoBehaviour {

	Animator anim;

	// Use this for initialization
	void Start () {

		// Get this animator
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKey(KeyCode.Alpha1)){

			anim.Play("talking_on_a_cell_phone");
		}

		if(Input.GetKey(KeyCode.Alpha2)){

			anim.Play("walking");
		}

		if(Input.GetKey(KeyCode.Alpha3)){
			anim.Play("bashful");
		}

		if(Input.GetKey(KeyCode.Alpha4)){

			anim.Play("ymca_dance");
		}
	}
}
