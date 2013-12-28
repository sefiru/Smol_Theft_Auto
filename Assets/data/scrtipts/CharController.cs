using UnityEngine;
using System.Collections;

public class CharController : MonoBehaviour {

	public int bulletImpulse = 1;
	public float shootSpeed = 1;
	public GameObject bullet;
	public GameObject thisPack;
	public float lastShotTime;

	public bool inCar = false;

	// Use this for initialization
	void Start () {
		lastShotTime = 0;
	}
	
	// Update is called once per frame
	void Update () {
		//thisPack.transform.position = 
			//new Vector3(bullet.transform.position.x, bullet.transform.position.y);
		//transform.Translate(Vector3.forward * Time.deltaTime)
		if (!inCar) {
			if (Input.GetKey(KeyCode.W)) {
				if (Time.time>(lastShotTime + shootSpeed)) {
					bullet.rigidbody.AddForce(transform.forward*bulletImpulse, ForceMode.Impulse);
					lastShotTime = Time.time;
				}
			}
		}
	}
}