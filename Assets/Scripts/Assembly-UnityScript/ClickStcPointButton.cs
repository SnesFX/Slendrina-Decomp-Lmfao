using System;
using UnityEngine;

[Serializable]
public class ClickStcPointButton : MonoBehaviour
{
	public GameObject stcPointMenu;

	public GameObject playButton;

	public GameObject helpButton;

	public GameObject quitButton;

	public GameObject stcPointButton;

	public GameObject moreGamesButton;

	public GameObject fullVersionButton;

	public GUIText stcPoints;

	public GameObject ljudHolder;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		int i = 0;
		Touch[] touches = Input.touches;
		for (int length = touches.Length; i < length; i++)
		{
			if (touches[i].phase == TouchPhase.Ended && GetComponent<GUITexture>().HitTest(touches[i].position))
			{
				stcPoints.GetComponent<GUIText>().text = PlayerPrefs.GetInt("stcPoints").ToString();
				((MenuSounds)ljudHolder.GetComponent(typeof(MenuSounds))).buttonClick();
				stcPointMenu.SetActive(true);
				playButton.SetActive(false);
				helpButton.SetActive(false);
				quitButton.SetActive(false);
				stcPointButton.SetActive(false);
				moreGamesButton.SetActive(false);
				fullVersionButton.SetActive(false);
			}
		}
	}

	public virtual void Main()
	{
	}
}
