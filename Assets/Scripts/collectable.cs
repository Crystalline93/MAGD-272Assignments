﻿using UnityEngine;
using System.Collections;

public class collectable : MonoBehaviour {

	AudioSource audioSource;
	public AudioClip collectSound;



	// Use this for initialization
	void Start () {
		audioSource = GameObject.Find ("CollectableAS").GetComponent<AudioSource> ();
	
	}
	

	void OnTriggerEnter2D (Collider2D col){
		if(col.CompareTag("Player")){
			if(audioSource != null)	{
			audioSource.PlayOneShot (collectSound);
			statsManager.stars++;
			Destroy(gameObject);
			}
		}

	}
}
