using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsManager : MonoBehaviour {


	private AudioSource
	music,
	effects;

	public AudioClip[] sounds;

	void Start () {
		music = GameObject.Find ("BackgroundMusic").GetComponent<AudioSource> ();
		effects = GameObject.Find ("SoundEffects").GetComponent<AudioSource> ();
			
	}

	void Update () {
		if (music.volume < 0.6f)
		music.volume += 0.001f;
	}

	public void SoundAppearance()
	{
		effects.PlayOneShot (sounds[0]);
	}

	public void SoundHit1()
	{
		effects.PlayOneShot (sounds[1]);
	}

	public void SoundHit2()
	{
		effects.PlayOneShot (sounds[2]);
	}

	public void SoundIdle()
	{
		effects.clip = sounds[3];
		effects.Play();
	}
}
