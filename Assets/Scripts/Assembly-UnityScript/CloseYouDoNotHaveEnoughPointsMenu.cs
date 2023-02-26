using System;
using UnityEngine;

[Serializable]
public class CloseYouDoNotHaveEnoughPointsMenu : MonoBehaviour
{
	public GameObject level1Button;

	public GameObject level2Button;

	public GameObject level3Button;

	public GameObject backButton;

	public GameObject Menu;

	public GameObject ljudHolder;

	public virtual void Update()
	{
		int i = 0;
		Touch[] touches = Input.touches;
		for (int length = touches.Length; i < length; i++)
		{
			if (touches[i].phase == TouchPhase.Ended && GetComponent<GUITexture>().HitTest(touches[i].position))
			{
				((MenuSounds)ljudHolder.GetComponent(typeof(MenuSounds))).buttonClick();
				((Cellar1LevelsButton)level1Button.GetComponent(typeof(Cellar1LevelsButton))).enabled = true;
				((Cellar2LevelButton)level2Button.GetComponent(typeof(Cellar2LevelButton))).enabled = true;
				((Cellar3LevelButton)level3Button.GetComponent(typeof(Cellar3LevelButton))).enabled = true;
				((ClickBackButton2)backButton.GetComponent(typeof(ClickBackButton2))).enabled = true;
				Menu.SetActive(false);
			}
		}
	}

	public virtual void Main()
	{
	}
}
