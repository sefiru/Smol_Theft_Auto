using UnityEngine;
using System.Collections;

public class CharMouseLook : MonoBehaviour {

	public GameObject camera;

	public float sensitivityX = 15F;
	public float sensitivityY = 15F;
	
	public float minimumX = -360F;
	public float maximumX = 360F;
	
	public float minimumY = -60F;
	public float maximumY = 60F;
	
	float rotationY = 0F;

	// Use this for initialization
	void Start () {
		if (rigidbody)
			rigidbody.freezeRotation = true;
	}
	
	// Update is called once per frame
	void Update () {
		float rotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivityX;

		transform.localEulerAngles = new Vector3(0, rotationX, 0);

		rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
		rotationY = Mathf.Clamp (rotationY, minimumY, maximumY);

		camera.transform.localEulerAngles = new Vector3(-rotationY, 0, 0);

	}
}
