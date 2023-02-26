using System;
using UnityEngine;

[Serializable]
public class ClickPlayButton : MonoBehaviour
{
	public GameObject button;

	public GameObject startMenu;

	public GameObject difficultyMenu;

	public GameObject ljudHolder;

	public virtual void Update()
	{
	}

	public virtual void OnMouseEnter()
	{
		button.transform.localScale = new Vector3(0.26f, 0.23f, 1f);
		((MenuSounds)ljudHolder.GetComponent(typeof(MenuSounds))).buttonOver();
	}

	public virtual void OnMouseExit()
	{
		button.transform.localScale = new Vector3(0.25f, 0.23f, 1f);
		((MenuSounds)ljudHolder.GetComponent(typeof(MenuSounds))).buttonOver();
	}

	public virtual void OnMouseDown()
	{
		button.transform.localScale = new Vector3(0.25f, 0.23f, 1f);
		startMenu.SetActive(false);
		difficultyMenu.SetActive(true);
		((MenuSounds)ljudHolder.GetComponent(typeof(MenuSounds))).buttonClick();
	}

	public virtual void Main()
	{
	}
}
