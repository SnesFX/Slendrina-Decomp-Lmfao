using System;
using UnityEngine;

[Serializable]
public class ClickBackButton2 : MonoBehaviour
{
	public GameObject button;

	public GameObject levelsMenu;

	public GameObject startMenu;

	public GameObject ljudHolder;

	public virtual void OnMouseEnter()
	{
		button.transform.localScale = new Vector3(0.11f, 0.09f, 1f);
		((MenuSounds)ljudHolder.GetComponent(typeof(MenuSounds))).buttonOver();
	}

	public virtual void OnMouseExit()
	{
		button.transform.localScale = new Vector3(0.1f, 0.09f, 1f);
		((MenuSounds)ljudHolder.GetComponent(typeof(MenuSounds))).buttonOver();
	}

	public virtual void OnMouseDown()
	{
		button.transform.localScale = new Vector3(0.1f, 0.09f, 1f);
		startMenu.SetActive(true);
		levelsMenu.SetActive(false);
		((MenuSounds)ljudHolder.GetComponent(typeof(MenuSounds))).buttonClick();
	}

	public virtual void Main()
	{
	}
}
