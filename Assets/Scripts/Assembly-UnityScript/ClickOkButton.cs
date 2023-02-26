using System;
using UnityEngine;

[Serializable]
public class ClickOkButton : MonoBehaviour
{
	public GameObject button;

	public GameObject helpMenu;

	public GameObject quitButton;

	public GameObject playButton;

	public GameObject helpButton;

	public GameObject ljudHolder;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
	}

	public virtual void OnMouseEnter()
	{
		button.transform.localScale = new Vector3(0.2f, 0.15f, 1f);
		((MenuSounds)ljudHolder.GetComponent(typeof(MenuSounds))).buttonOver();
	}

	public virtual void OnMouseExit()
	{
		button.transform.localScale = new Vector3(0.19f, 0.15f, 1f);
		((MenuSounds)ljudHolder.GetComponent(typeof(MenuSounds))).buttonOver();
	}

	public virtual void OnMouseDown()
	{
		button.transform.localScale = new Vector3(0.19f, 0.15f, 1f);
		((MenuSounds)ljudHolder.GetComponent(typeof(MenuSounds))).buttonClick();
		quitButton.SetActive(true);
		playButton.SetActive(true);
		helpButton.SetActive(true);
		helpMenu.SetActive(false);
	}

	public virtual void Main()
	{
	}
}
