using UnityEngine;
using System.Collections;

public class Crosshair : MonoBehaviour {
	
	public Texture2D crosshairTexture;
	private Rect r;
	
	// Use this for initialization
	void Start () {
		r.Set((Screen.width/2) - (crosshairTexture.width/2),
			(Screen.height/2) - (crosshairTexture.height/2),
			crosshairTexture.width,crosshairTexture.height);
	}
	
	// Update is called once per frame
	void Update () {
		//r = Rect(0,0,0);
			/*Rect((Screen.width/2) - (crosshairTexture.width/2),
			(Screen.height/2) - (crosshairTexture.height/2),
			crosshairTexture.width,crosshairTexture.height);*/
	}
	
	
	void OnGUI () {
	   GUI.Label(r,crosshairTexture);
	}
}
