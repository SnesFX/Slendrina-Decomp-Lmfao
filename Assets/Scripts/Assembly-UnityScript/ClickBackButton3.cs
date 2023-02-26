using System;
using UnityEngine;

[Serializable]
public class ClickBackButton3 : MonoBehaviour
{
	public GameObject button;

	public GameObject startMenu;

	public GameObject difficultyMenu;

	public GameObject ljudHolder;

	public GameObject gameController;

	public virtual void Update()
	{
	}

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
		((StartScenes)gameController.GetComponent(typeof(StartScenes))).level1 = false;
		((StartScenes)gameController.GetComponent(typeof(StartScenes))).level2 = false;
		((StartScenes)gameController.GetComponent(typeof(StartScenes))).level3 = false;
		startMenu.SetActive(true);
		difficultyMenu.SetActive(false);
		((MenuSounds)ljudHolder.GetComponent(typeof(MenuSounds))).buttonClick();
	}

	public virtual void Main()
	{
	}
}
