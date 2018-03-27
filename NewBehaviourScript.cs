using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
	public enum Player{ player0,player1,player2 };
	private Player[,] symbol = new Player[3, 3];
	public bool turn = true;
	public bool playing = true;

	void start(){
		Reset ();
	}

	void OnGUI(){
		int bHeight = 100;
		int bWidth = 100;
		float height = Screen.height * 0.5f - 150;
		float width = Screen.width * 0.5f - 150;
		GUI.Button (new Rect (width, height, bWidth, bHeight), "");
		for (int i = 0; i < 3; ++i) {
			for (int j = 0; j < 3; ++j) {
				GUI.Button (new Rect (width + i * bWidth, height + j * bHeight, bWidth, bHeight), "");
			}
		}
		Player winner=check();
		if (winner != Player.player0) {
			playing = !playing;
			GUI.enabled = false;
			Debug.Log ("hhh");
		}
		for(int i=0; i<3; i++) {
			for (int j = 0; j < 3; j++) {
				if (symbol [i, j] == Player.player1) {
					GUI.Button (new Rect (width + i * bWidth, height + j * bHeight, bWidth, bHeight), "X");
				} else if (symbol [i, j] == Player.player2) {
					GUI.Button (new Rect (width + i * bWidth, height + j * bHeight, bWidth, bHeight), "o");
				} else {
					if (GUI.Button (new Rect (width + i * bWidth, height + j * bHeight, bWidth, bHeight), "")) {
						if (playing == true) {
							if (turn == true) {
								symbol [i, j] = Player.player1;
							} else {
								symbol [i, j] = Player.player2;
							}
								turn = !turn;
						}
					}
				}
			}
		}
		GUI.enabled = true;
	}

	private Player check(){
		for (int i = 0; i < 3; i++) {
			if (symbol[i,0]!=Player.player0 && symbol [i, 0] == symbol [i, 1] && symbol [i, 1] == symbol [i, 2]) {
				return symbol [i, 0];
			}
		}
		for (int j = 0; j < 3; j++) {
			if (symbol[0,j]!=Player.player0 && symbol [0, j] == symbol [1, j] && symbol [2, j] == symbol [1, j]) {
				return symbol [0, j];
			}
		}
		if(symbol[1,1]!=Player.player0){
			if (symbol[1,1]!=Player.player0 && symbol [1, 1] == symbol [0, 0] && symbol [1, 1] == symbol [2, 2]) {
				return symbol [1, 1];
			}
		}
		return Player.player0;
	}
	// Use this for initialization
	private void Reset(){
		playing = true;
		turn = true;
		for (int i = 0; i < 3; i++) {
			for (int j = 0; j < 3; j++) {
				symbol [i, j] = Player.player0;
			}
		}
		GUI.enabled = true;
	}
	// Update is called once per frame
}
