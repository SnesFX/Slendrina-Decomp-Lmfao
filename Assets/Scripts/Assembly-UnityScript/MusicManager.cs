using System;
using UnityEngine;

[Serializable]
[RequireComponent(typeof(AudioSource))]
public class MusicManager : MonoBehaviour
{
	public AudioClip[] musicClips;

	public virtual void Start()
	{
		if (musicClips.Length < 4)
		{
			Debug.LogWarning("Need 4 Music Tracks in the Inspector");
		}
		GetComponent<AudioSource>().loop = true;
		GetComponent<AudioSource>().clip = musicClips[0];
		GetComponent<AudioSource>().Play();
	}

	public virtual void PlayMusicTrack(int trackNumber)
	{
		GetComponent<AudioSource>().Stop();
		GetComponent<AudioSource>().clip = musicClips[trackNumber];
		GetComponent<AudioSource>().Play();
	}

	public virtual void Main()
	{
	}
}
