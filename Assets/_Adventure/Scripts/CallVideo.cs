using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallVideo : MonoBehaviour
{

	public bool trigger;
	public UnityEngine.Video.VideoPlayer videoPlayer;

	void Start ()
	{
		StartCoroutine ("waitForMovieEnd");
	}

	IEnumerator waitForMovieEnd ()
	{

		while (videoPlayer.isPlaying) { 
			yield return new WaitForEndOfFrame ();
		}

		onMovieEnded ();
	}

	void onMovieEnded ()
	{
		Application.LoadLevel ("Menu");
	}
}
