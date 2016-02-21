using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class StatsModifier : MonoBehaviour {

	public Text healthTargetText;
	public Text scoreTargetText;
	public Text livesTargetText;
	public Text charismaTargetText;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Alpha0)) {
			StatsManager.healthCount++;
			Debug.Log (StatsManager.healthCount);
			healthTargetText.text = StatsManager.healthCount.ToString();
		}
		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			StatsManager.scoreCount++;
			Debug.Log (StatsManager.scoreCount);
			scoreTargetText.text = StatsManager.scoreCount.ToString();
		}
		if (Input.GetKeyDown (KeyCode.Alpha2)) {
			StatsManager.livesCount++;
			Debug.Log (StatsManager.livesCount);
			livesTargetText.text = StatsManager.livesCount.ToString();
		}
		if (Input.GetKeyDown (KeyCode.Alpha3)) {
			StatsManager.charismaCount++;
			Debug.Log (StatsManager.charismaCount);
			charismaTargetText.text = StatsManager.charismaCount.ToString();
		}

	
	}



}
