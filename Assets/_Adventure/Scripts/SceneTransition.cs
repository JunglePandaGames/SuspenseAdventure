﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour {
	
	public string destiny;
    public Vector3 destinyPosition;
	public Quaternion orientation;
    // Use this for initialization
    private void Start()
    {
		
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) {
			FadeManager.Instance.Fade (true, 1f);
            //other.transform.position = destinyPosition;
			StartCoroutine(LoadScene(other));
            //other.transform.position = destinyPosition;
            
        }

    }

	IEnumerator LoadScene(Collider player){
		yield return new WaitForSeconds (1f);
		player.transform.position = destinyPosition;
		player.transform.rotation = orientation;
		SceneManager.LoadScene (destiny);
		FadeManager.Instance.Fade (false, 1f);
	}
}
