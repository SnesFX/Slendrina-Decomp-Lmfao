using System;
using UnityEngine;

[Serializable]
public class Cellar3LevelButton : MonoBehaviour
{
	public GameObject button;

	public GameObject difficultyMenu;

	public GameObject ljudHolder;

	public GameObject levelsMenu;

	public GameObject gameController;

	public virtual void OnMouseEnter()
	{
		button.transform.localScale = new Vector3(0.24f, 0.23f, 1f);
		((MenuSounds)ljudHolder.GetComponent(typeof(MenuSounds))).buttonOver();
	}

	public virtual void OnMouseExit()
	{
		button.transform.localScale = new Vector3(0.23f, 0.23f, 1f);
		((MenuSounds)ljudHolder.GetComponent(typeof(MenuSounds))).buttonOver();
	}

	public virtual void OnMouseDown()
	{
		button.transform.localScale = new Vector3(0.23f, 0.23f, 1f);
		((StartScenes)gameController.GetComponent(typeof(StartScenes))).level1 = false;
		((StartScenes)gameController.GetComponent(typeof(StartScenes))).level2 = false;
		((StartScenes)gameController.GetComponent(typeof(StartScenes))).level3 = true;
		levelsMenu.SetActive(false);
		difficultyMenu.SetActive(true);
		((MenuSounds)ljudHolder.GetComponent(typeof(MenuSounds))).buttonClick();
	}

	public virtual void Main()
	{
	}
}
