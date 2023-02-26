using System;
using UnityEngine;

[Serializable]
public class ClickHardButton : MonoBehaviour
{
	public GameObject difficultyHolder;

	public GameObject hardButton;

	public GameObject easyButton;

	public GameObject mediumButton;

	public GameObject ljudHolder;

	public GameObject loadingText;

	public GameObject backButton;

	public GameObject gameController;

	public virtual void Update()
	{
	}

	public virtual void OnMouseEnter()
	{
		hardButton.transform.localScale = new Vector3(0.16f, 0.1f, 1f);
		((MenuSounds)ljudHolder.GetComponent(typeof(MenuSounds))).buttonOver();
	}

	public virtual void OnMouseExit()
	{
		hardButton.transform.localScale = new Vector3(0.15f, 0.1f, 1f);
		((MenuSounds)ljudHolder.GetComponent(typeof(MenuSounds))).buttonOver();
	}

	public virtual void OnMouseDown()
	{
		((MenuSounds)ljudHolder.GetComponent(typeof(MenuSounds))).diffbuttonClick();
		BetweenScenesValues.difficultyEasy = false;
		BetweenScenesValues.difficultyMedium = false;
		BetweenScenesValues.difficultyHard = true;
		hardButton.SetActive(false);
		mediumButton.SetActive(false);
		easyButton.SetActive(false);
		backButton.SetActive(false);
		loadingText.SetActive(true);
		play();
	}

	public virtual void play()
	{
		((StartScenes)gameController.GetComponent(typeof(StartScenes))).ready = true;
	}

	public virtual void Main()
	{
	}
}
