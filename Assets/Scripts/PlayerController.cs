using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;

	CharacterController cc;

	// Use this for initialization
	void Start () {
		cc = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 velocity = Vector3.zero;

		velocity += transform.forward * speed * Input.GetAxis("Vertical");
		velocity += transform.right * speed * Input.GetAxis("Horizontal");

		cc.SimpleMove(velocity);
	}
}
