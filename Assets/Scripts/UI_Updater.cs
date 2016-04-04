using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UI_Updater : MonoBehaviour {

	public Text score;
	public Text lives;
	// Update is called once per frame
	void Update () {
		score.text = statsManager.stars.ToString();
		lives.text = statsManager.lives.ToString();
	}
}
