using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Manager : MonoBehaviour {

	//--------Mic Input----------
	public AudioSource micInput;
	public AudioMixer MicMixer;

	//private float input;
	//private bool boton;

	//---------------------------

	public AudioSource audioSource1;
	public AudioSource audioSource2;
	public AudioSource audioSource3;
	public AudioSource audioSource4;

	public AudioMixer mixer;

	public Button b1;
	public Button b2;
	public Button b3;
	public Button b4;

	bool b1press=false;
	bool b2press=false;
	bool b3press=false;
	bool b4press=false;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		Debug.Log (micInput.volume);

		//Button1
		Debug.Log(b1press);
		if ( ((micInput.volume > 0.5) && b1press ) && (audioSource1.isPlaying == false)) {
			Debug.Log ("Start 1");
			audioSource1.Play ();
		}
		if ( ((micInput.volume < 0.5) || (b1press == false)) && (audioSource1.isPlaying == true)) {
			Debug.Log ("Stopt cond 1");

			audioSource1.Stop ();
		}

		//Button2
		Debug.Log(b2press);
		if ( ((micInput.volume > 0.5) && b2press ) && (audioSource2.isPlaying == false)) {
			Debug.Log ("Start 2");
			audioSource2.Play ();
		}
		if ( ((micInput.volume < 0.5) || (b2press == false)) && (audioSource2.isPlaying == true)) {
			Debug.Log ("Stopt cond 2");

			audioSource2.Stop ();
		}

		//Button3
		Debug.Log(b3press);
		if ( ((micInput.volume > 0.5) && b3press ) && (audioSource3.isPlaying == false)) {
			Debug.Log ("Start 3");
			audioSource3.Play ();
		}
		if ( ((micInput.volume < 0.5) || (b3press == false)) && (audioSource3.isPlaying == true)) {
			Debug.Log ("Stopt cond 3");

			audioSource3.Stop ();
		}

		//Button4
		Debug.Log(b4press);
		if ( ((micInput.volume > 0.5) && b4press ) && (audioSource4.isPlaying == false)) {
			Debug.Log ("Start 4");
			audioSource4.Play ();
		}
		if ( ((micInput.volume < 0.5) || (b4press == false)) && (audioSource4.isPlaying == true)) {
			Debug.Log ("Stopt cond 4");

			audioSource4.Stop ();
		}

	}


	public void B1OnClick () {
		b1press = true;

	}

	public void B1OffClick (){
		b1press = false;
		//Debug.Log ("Stop click");
		audioSource1.Stop ();
	}


	public void B2OnClick () {
		b2press = true;
	}

	public void B2OffClick (){
		b2press = false;
		//Debug.Log ("Stop click");
		audioSource2.Stop ();
	}


	public void B3OnClick () {
		b3press = true;
	}

	public void B3OffClick (){
		b3press = false;
		//Debug.Log ("Stop click");
		audioSource3.Stop ();
	}


	public void B4OnClick () {
		b4press = true;
	}

	public void B4OffClick (){
		b4press = false;
		//Debug.Log ("Stop click");
		audioSource4.Stop ();
	}


}
