using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour {

	// Use this for initialization
	void Start() {

	}

	// Update is called once per frame
	void Update() {

	}

	public void OnCollisionEnter(Collision collision) {
		if ((collision.gameObject.layer & 10) != 0) {
			Debug.Log("Collision with ground");

			GetComponent<Rigidbody>().velocity = Vector3.zero;
			GetComponent<Rigidbody>().useGravity = false;
			if (GetComponent<SpringJoint>() == null) {
				gameObject.AddComponent<SpringJoint>().autoConfigureConnectedAnchor = false;
				GetComponent<SpringJoint>().connectedAnchor = new Vector3(transform.position.x, 2.5f, transform.position.z);
			}
		}
	}

	public void OnTriggerEnter(Collider other) {
		if(other.tag == "Player") {
			Debug.Log("Hit Player");
			Destroy(gameObject);
		}
	}
}
