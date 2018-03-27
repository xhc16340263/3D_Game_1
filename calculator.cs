using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	int bHeight = 50;
	int bWidth = 80;
	float height = Screen.height * 0.5f - 125;
	float width = Screen.width * 0.5f - 160;
	void start() {
		GUI.Button (new Rect (width, height - bHeight, 4 * bWidth, bHeight), "");
	}

	void OnGUI(){
		GUI.Button (new Rect (width, height, bWidth, bHeight), "");
		GUI.Button (new Rect (width + 0 * bWidth, height + 0 * bHeight, bWidth, bHeight), "7");
		GUI.Button (new Rect (width + 1 * bWidth, height + 0 * bHeight, bWidth, bHeight), "8");
		GUI.Button (new Rect (width + 2 * bWidth, height + 0 * bHeight, bWidth, bHeight), "9");
		GUI.Button (new Rect (width + 3 * bWidth, height + 0 * bHeight, bWidth, bHeight), "/");
		GUI.Button (new Rect (width + 0 * bWidth, height + 1 * bHeight, bWidth, bHeight), "4");
		GUI.Button (new Rect (width + 1 * bWidth, height + 1 * bHeight, bWidth, bHeight), "5");
		GUI.Button (new Rect (width + 2 * bWidth, height + 1 * bHeight, bWidth, bHeight), "6");
		GUI.Button (new Rect (width + 3 * bWidth, height + 1 * bHeight, bWidth, bHeight), "*");
		GUI.Button (new Rect (width + 0 * bWidth, height + 2 * bHeight, bWidth, bHeight), "1");
		GUI.Button (new Rect (width + 1 * bWidth, height + 2 * bHeight, bWidth, bHeight), "2");
		GUI.Button (new Rect (width + 2 * bWidth, height + 2 * bHeight, bWidth, bHeight), "3");
		GUI.Button (new Rect (width + 3 * bWidth, height + 2 * bHeight, bWidth, bHeight), "-");
		GUI.Button (new Rect (width + 0 * bWidth, height + 3 * bHeight, bWidth, bHeight), "0");
		GUI.Button (new Rect (width + 1 * bWidth, height + 3 * bHeight, bWidth, bHeight), ".");
		GUI.Button (new Rect (width + 2 * bWidth, height + 3 * bHeight, bWidth, bHeight), "←");
		GUI.Button (new Rect (width + 3 * bWidth, height + 3 * bHeight, bWidth, bHeight), "+");
		GUI.Button (new Rect (width + 0 * bWidth, height + 4 * bHeight, bWidth, bHeight), "(");
		GUI.Button (new Rect (width + 1 * bWidth, height + 4 * bHeight, bWidth, bHeight), ")");
		GUI.Button (new Rect (width + 2 * bWidth, height + 4 * bHeight, bWidth, bHeight), "CE");
		GUI.Button (new Rect (width + 3 * bWidth, height + 4 * bHeight, bWidth, bHeight), "=");
		GUI.Button (new Rect (width, height - bHeight, 4 * bWidth, bHeight), "");

		if (GUI.Button (new Rect (width + 0 * bWidth, height + 0 * bHeight, bWidth, bHeight), "7")) {
			Debug.Log ("hhh");
			GUI.Button (new Rect (width, height - bHeight, 4 * bWidth, bHeight), "3");
		}
	}
}