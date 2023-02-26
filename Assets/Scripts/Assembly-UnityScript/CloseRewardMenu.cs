using System;
using UnityEngine;

[Serializable]
public class CloseRewardMenu : MonoBehaviour
{
	public GameObject rewardMenu;

	public GameObject stcOkButton;

	public GameObject videoButton;

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
				rewardMenu.SetActive(false);
				stcOkButton.SetActive(true);
				videoButton.SetActive(true);
			}
		}
	}

	public virtual void Main()
	{
	}
}
