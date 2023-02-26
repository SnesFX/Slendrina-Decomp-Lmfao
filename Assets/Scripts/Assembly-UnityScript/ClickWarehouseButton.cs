using System;
using UnityEngine;

[Serializable]
public class ClickWarehouseButton : MonoBehaviour
{
	public GameObject difficultyMenu;

	public GameObject levelMenu;

	public GameObject whatLevel;

	public GameObject ljudHolder;

	public virtual void Update()
	{
		int i = 0;
		Touch[] touches = Input.touches;
		for (int length = touches.Length; i < length; i++)
		{
			if (touches[i].phase == TouchPhase.Ended && GetComponent<GUITexture>().HitTest(touches[i].position))
			{
				difficultyMenu.SetActive(true);
				levelMenu.SetActive(false);
				((MenuButtonSounds)ljudHolder.GetComponent(typeof(MenuButtonSounds))).buttonClick();
				((WhatLevelIsVald)whatLevel.GetComponent(typeof(WhatLevelIsVald))).warehouse = true;
				((WhatLevelIsVald)whatLevel.GetComponent(typeof(WhatLevelIsVald))).hotel = false;
				((WhatLevelIsVald)whatLevel.GetComponent(typeof(WhatLevelIsVald))).yard = false;
				((WhatLevelIsVald)whatLevel.GetComponent(typeof(WhatLevelIsVald))).swamp = false;
				ShowAd();
			}
		}
	}

	public virtual void ShowAd()
	{
	}

	public virtual void Main()
	{
	}
}
