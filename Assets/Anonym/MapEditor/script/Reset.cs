﻿using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Reset : MonoBehaviour {

	public Image deathImage;
	private AudioSource music;
	// Use this for initialization
	void Start () {
		//deathImage.enabled = false;
		music = GameObject.Find("MusicTime").GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {        
        if (Input.GetKeyDown(KeyCode.R)) {
			Restart();
        }
		
	}

	public void Restart() {
		LoggingManager.instance.RecordEvent(1, "Player pressed Restart button.");
		//if(!GameObject.Find("MusicTime").GetComponent<AudioSource>().isPlaying)
		music.volume = 0.1f;
		// if(!music.isPlaying)
		// 	music.UnPause();
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
