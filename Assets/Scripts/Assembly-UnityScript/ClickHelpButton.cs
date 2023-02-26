using System;
using UnityEngine;

[Serializable]
public class ClickHelpButton : MonoBehaviour
{
	public GameObject helpMenu;

	public GameObject quitButton;

	public GameObject playButton;

	public GameObject helpButton;

	public GameObject ljudHolder;

	public virtual void Update()
	{
	}

	public virtual void OnMouseEnter()
	{
		helpButton.transform.localScale = new Vector3(0.26f, 0.23f, 1f);
		((MenuSounds)ljudHolder.GetComponent(typeof(MenuSounds))).buttonOver();
	}

	public virtual void OnMouseExit()
	{
		helpButton.transform.localScale = new Vector3(0.25f, 0.23f, 1f);
		((MenuSounds)ljudHolder.GetComponent(typeof(MenuSounds))).buttonOver();
	}

	public virtual void OnMouseDown()
	{
		helpButton.transform.localScale = new Vector3(0.25f, 0.23f, 1f);
		((MenuSounds)ljudHolder.GetComponent(typeof(MenuSounds))).buttonClick();
		quitButton.SetActive(false);
		playButton.SetActive(false);
		helpButton.SetActive(false);
		helpMenu.SetActive(true);
	}

	public virtual void Main()
	{
	}
}
