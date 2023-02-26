using System;
using UnityEngine;

[Serializable]
public class YouWinSound : MonoBehaviour
{
	public AudioClip youWinLjud;

	public virtual void Start()
	{
	}

	public virtual void winSound()
	{
		AudioSource.PlayClipAtPoint(youWinLjud, transform.position);
	}

	public virtual void Main()
	{
	}
}
