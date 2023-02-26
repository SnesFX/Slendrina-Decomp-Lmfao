using System;
using UnityEngine;

[Serializable]
public class MenuButtonSounds : MonoBehaviour
{
	public AudioClip buttonLjud;

	public AudioClip difficultyLjud;

	public virtual void buttonClick()
	{
		AudioSource.PlayClipAtPoint(buttonLjud, transform.position);
	}

	public virtual void difficultyClick()
	{
		AudioSource.PlayClipAtPoint(difficultyLjud, transform.position);
	}

	public virtual void Main()
	{
	}
}
