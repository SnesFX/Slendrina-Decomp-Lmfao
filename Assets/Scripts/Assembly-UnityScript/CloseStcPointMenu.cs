using System;
using UnityEngine;

[Serializable]
public class CloseStcPointMenu : MonoBehaviour
{
	public GameObject stcPointMenu;

	public GameObject playButton;

	public GameObject helpButton;

	public GameObject quitButton;

	public GameObject stcPointButton;

	public GameObject moreGamesButton;

	public GameObject fullVersionButton;

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
				stcPointMenu.SetActive(false);
				playButton.SetActive(true);
				helpButton.SetActive(true);
				quitButton.SetActive(true);
				stcPointButton.SetActive(true);
				moreGamesButton.SetActive(true);
				fullVersionButton.SetActive(true);
			}
		}
	}

	public virtual void Main()
	{
	}
}
