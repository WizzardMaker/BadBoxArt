using UnityEngine;
using System.Collections;
using UnityEditor;

public class PlayerController : MonoBehaviour {

	public float speed;

	public float size;

	CharacterController cc;
	ParticleSystem fire;

	// Use this for initialization
	void Start () {
		cc = GetComponent<CharacterController>();
		fire = GetComponentInChildren<ParticleSystem>();
	}

	void Move() {
		Vector3 velocity = Vector3.zero;

		velocity += transform.forward * speed * Input.GetAxis("Vertical");
		velocity += transform.right * speed * Input.GetAxis("Horizontal");

		cc.SimpleMove(velocity);
	}
	
	// Update is called once per frame
	void Update () {
		Move();

		size = Mathf.Clamp(size, 0.1f, 10f);

		transform.localScale = Vector3.one * size;

		ParticleSystem.ShapeModule shapeModule = fire.shape;
		shapeModule.radius = 1 * size;
	}
}
