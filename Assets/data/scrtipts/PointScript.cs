using UnityEngine;
using System.Collections;

public class PointScript : MonoBehaviour {
	//bool mous;
	public Color selectedY;
	public Color selectedN;
	private bool mouse;
	private bool inCar;
	
	//GameObject mainObject;
	
	// Use this for initialization
	void Start () {
		//mainObject = GameObject.Find("MainScriptObject");
		selectedY = Color.green;
		
		selectedN = gameObject.renderer.material.color;
	}
	
	// Update is called once per frame
	void Update () {
		if (inCar) {
			GameObject player = GameObject.Find("Player");
			player.transform.localPosition = new Vector3(0, 0.5f, 0);
			if (Input.GetKeyDown(KeyCode.F)) {
				gameObject.GetComponent<CarController>().inCar = false;
				inCar = false;
				player.GetComponent<Rigidbody>().collider.enabled = true;
				player.GetComponent<CharController>().inCar = false;
				player.transform.localPosition = new Vector3(0, 3, 0);
				player.transform.parent = null;
			}
		}
		if (Input.GetKeyDown(KeyCode.F) && mouse && !inCar) {
			gameObject.GetComponent<CarController>().inCar = true;
			GameObject player = GameObject.Find("Player");
			player.GetComponent<Rigidbody>().collider.enabled = false;
			player.GetComponent<CharController>().inCar = true;
			player.transform.parent = transform;
			player.transform.localPosition = new Vector3(0, 0.5f, 0);
			inCar = true;
		}
		
	}
    void OnMouseEnter() {
		//gameObject.transform.renderer.material.color.a = (float)0.2;
		gameObject.transform.renderer.material.color = selectedY;
		mouse = true;
		//this.renderer.material.color.a = 0.2;
		//mous = true;
    }
    void OnMouseExit() {
		gameObject.transform.renderer.material.color = selectedN;
		mouse = false;
		//mous = false;
    }
}
