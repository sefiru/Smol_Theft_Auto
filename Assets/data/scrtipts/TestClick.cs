using UnityEngine;
using System.Collections;

public class TestClick : MonoBehaviour {
	bool mous;
	public Color selectedY = Color.green;
	public Color selectedN;
	public string type;
	public int ID;
	
	GameObject mainObject;
	
	// Use this for initialization
	void Awake () {
		//Debug.Log(gameObject.name.ToString());
		//ID = int.Parse(gameObject.name.ToString());
		//Debug.Log(ID);
	}
	
	void Start () {
		mainObject = GameObject.Find("MainScriptObject");
		selectedN = gameObject.renderer.material.color;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Mouse0) && mous) {
			
			string[] temp = getXYZToClient(gameObject.GetComponent<TestClick>().type,
				transform.position.x, transform.position.y, transform.position.z);

			
			/*if (GameObject.Find("MainScriptObject").GetComponent<GlobalVars>().invisObject != null)
					GameObject.Find("MainScriptObject").GetComponent<GlobalVars>().
					invisObject.renderer.enabled = true;*/
			//GameObject.Find("MainScriptObject").GetComponent<GlobalVars>().invisObject = gameObject;
			//mainObject.GetComponent<CreateScene>().createShipBomber(5, 5, 5);
			//Debug.Log(obj.GetComponent("CreateScene").createShipBomber());
			//GetComponent<CreateScene>().createShipBomber();
		}
		if (Input.GetKeyDown(KeyCode.Mouse0) && mous) {
			
			GameObject[] objects = GameObject.FindGameObjectsWithTag("movePoint");
			for(int i = 0; i < objects.Length; i++) {
				GameObject.Destroy(objects[i]);
			}
			
			GameObject[] tempObjs = GameObject.FindGameObjectsWithTag("ship");
			foreach (GameObject temp0 in tempObjs) {
				temp0.GetComponent<TestClick>().colorRed(false);
			}
			
			string[] temp = getXYZToClient(gameObject.GetComponent<TestClick>().type,
				transform.position.x, transform.position.y, transform.position.z);
			//string[] temp2 = null;
			/*if (GameObject.Find("MainScriptObject").GetComponent<GlobalVars>().invisObject != null) {
				GameObject tempObj = GameObject.Find("MainScriptObject").GetComponent<GlobalVars>().invisObject;
				string[] temp2 = getXYZToClient(tempObj.GetComponent<TestClick>().type,
					tempObj.transform.position.x, tempObj.transform.position.y, tempObj.transform.position.z);
			*/
			
			//if (GameObject.Find("MainScriptObject").GetComponent<GlobalVars>().invisObject != null)
					/*GameObject.Find("MainScriptObject").GetComponent<GlobalVars>().
					invisObject.renderer.enabled = true;*/
			//}
		}
	}
	
	public void colorRed (bool check) {
		if (check)
			gameObject.renderer.material.color = Color.red;
		else
			gameObject.renderer.material.color = selectedN;
	}
	
    void OnMouseEnter() {
		gameObject.renderer.material.color = selectedY;
		mous = true;
		//Debug.Log(ID);
    }
    void OnMouseExit() {
		gameObject.renderer.material.color = selectedN;
		mous = false;
    }
	
	public string[] getXYZToClient (string type, float x, float y, float z) {
		switch (type) {
			case "shipScout":
				return new string[] {x + "", y + "", z + ""};
			case "shipMother":
				return new string[] {x - 1 + "", y - 1 + "", z - 1.5f + ""};
			case "shipSniper":
				return new string[] {x + "", y + "", z - 1 + ""};
			case "shipFighter":
				return new string[] {x - 0.5f + "", y + "", z - 1 + ""};
			case "shipBomber":
				return new string[] {x + "", y - 1 + "", z - 0.5 + ""};
			case "shipAssassin":
				return new string[] {x - 0.5f + "", y - 0.5f + "", z - 0.5f + ""};
		}
		return new string[] {"", "", ""};
	}
}
