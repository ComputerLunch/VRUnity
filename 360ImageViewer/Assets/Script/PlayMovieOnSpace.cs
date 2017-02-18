using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMovieOnSpace : MonoBehaviour {

	// video does not work on Android need a plugin
	#if !UNITY_ANDROID 

	void Start(){

	 

	

			// Play on start
			// this line of code will make the Movie Texture begin playing
			((MovieTexture)GetComponent<Renderer>().material.mainTexture).Play();

	}

	void Update () {

		 

		if (Input.GetButtonDown ("Jump")) {

			Renderer r = GetComponent<Renderer>();
			MovieTexture movie = (MovieTexture)r.material.mainTexture;

			if (movie.isPlaying) {
				movie.Pause();
			}
			else {
				movie.Play();
			}
		}


	}

	#endif
}
