using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class typeText : MonoBehaviour {
	public string typedText = "Hi, what is your name yo?";
	public float interLetterTime;
	public Text targetTextwindow;

	public InputField userInputField;
	// Use this for initialization
	void Start () {
		StartCoroutine (addText (typedText));
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator addText(string Text){
		int textLength = Text.Length;
		for (int i = 0; i < Text.Length+1; i++) {
			targetTextwindow.text = Text.Substring (0, i);
			yield return new WaitForSeconds (interLetterTime);
		}
	}

	public void storeUserName(){
		 StatsManager.userName = userInputField.text;
		StartCoroutine (addText ("Hi " + StatsManager.userName + " it's nice to meet you!"));
}
}