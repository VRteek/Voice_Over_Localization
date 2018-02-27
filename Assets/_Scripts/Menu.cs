using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Menu : MonoBehaviour {
	public Button b;
	// Use this for initialization
	void Awake () {
		
		string i = PlayerPrefs.GetString ("Selected_Language");
		if (i != "") {
			b.GetComponent<UnityEngine.UI.Image> ().sprite = Resources.Load ("flags/" + i, typeof (Sprite)) as Sprite;
		} else {
			SceneManager.LoadScene ("JSON_Download");
		}
	}

	// Update is called once per frame
	void Update () {

	}
	public void LoadScne (string s) {
		SceneManager.LoadScene (s);

	}

	
}