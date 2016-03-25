using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public static CameraController active;

	public GameObject target;

	public float distance;

	// Use this for initialization
	void Start () {
		active = this;
	}
	
	// Update is called once per frame
	void Update () {
		if (target == null)
			return;

		transform.position = target.transform.position - transform.forward * distance;
	}
}
