using UnityEngine;
using System.Collections;

public class obstacle : MonoBehaviour {
	
	public GameObject obstacle2destroy;
	
		
		
		void OnTriggerEnter2D (Collider2D col){
			if(col.CompareTag("Player")){
			//Destroy	(obstacle2destroy);
			obstacle2destroy.SetActive(false);
			}

		}
	}
