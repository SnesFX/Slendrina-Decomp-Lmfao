using System;
using UnityEngine;

[Serializable]
public class MenuSounds : MonoBehaviour
{
	public AudioClip clickSound;

	public AudioClip diffclickSound;

	public AudioClip overButton;

	public virtual void Start()
	{
		Time.timeScale = 1f;
		Cursor.visible = true;
		Screen.lockCursor = false;
		AudioListener.pause = false;
	}

	public virtual void buttonClick()
	{
		AudioSource.PlayClipAtPoint(clickSound, transform.position);
	}

	public virtual void buttonOver()
	{
		AudioSource.PlayClipAtPoint(overButton, transform.position);
	}

	public virtual void diffbuttonClick()
	{
		AudioSource.PlayClipAtPoint(diffclickSound, transform.position);
	}

	public virtual void Main()
	{
	}
}
