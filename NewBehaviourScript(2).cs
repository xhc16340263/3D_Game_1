using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class NewBehaviourScript : MonoBehaviour {

	public Transform btnParrent;
	public Button[] btn1;
	public Button btn2;

	// Use this for initialization
	void Start () {
		btnParrent = GameObject.Find ("Canvas").transform;
		btn1 = new Button[btnParrent.childCount];
		for (int i = 0; i < btnParrent.childCount; i++) {
			btn1 [i] = btnParrent.GetChild (i).GetComponent<Button> ();
		}

		for (int i = 0; i < btnParrent.childCount; i++) {
			btn1 [i].onClick.AddListener (delegate() {
				OnClick (btn1[i]);
			});
		}
		btn2 = EventSystem.current.currentSelectedGameObject.GetComponent<Button>();
		btn2.onClick = OnClick;
		 public void OnClick(GameObject sender){
			Debug.Log (sender.name);
			Text text1 = sender.transform.Find("Text").GetComponent<Text>();
			text1.text = "X";
		}
	}
			
	// Update is called once per frame
	void Update () {
		Debug.Log ("Update");
	}
}