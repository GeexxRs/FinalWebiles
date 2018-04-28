using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSC : MonoBehaviour {

	public float sensitivity = 10;
	public float loudness = 0;
	AudioSource _audio;

	// Use this for initialization
	void Start () {
		_audio = GetComponent <AudioSource> ();
		_audio.clip = Microphone.Start (null, true, 10, 44100);
		_audio.loop = true;
		//_audio.mute = true;
		while (!(Microphone.GetPosition (null) > 0)) {}
		_audio.Play ();
	}
	
	// Update is called once per frame
	void Update () {
		loudness = GetAveragedVolume () * sensitivity;
		if (loudness > 0.1) {
			this.GetComponent<Rigidbody2D> ().velocity = new Vector2 (this.GetComponent<Rigidbody2D> ().velocity.x, 4);
			_audio.volume = loudness;
		}
	}

	float GetAveragedVolume(){
		float[] data = new float[256];
		float a = 0;
		_audio.GetOutputData (data, 0);
		foreach(float s in data){
			a+=Mathf.Abs(s);
		}
		return a/256;
	}

}
