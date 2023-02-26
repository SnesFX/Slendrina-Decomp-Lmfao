using System;
using UnityEngine;

[Serializable]
public class StartDifficultyMenu : MonoBehaviour
{
	public GameObject difficultyMenu;

	public GameObject levelMenu;

	public GameObject whatLevel;

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
				((WhatLevelIsVald)whatLevel.GetComponent(typeof(WhatLevelIsVald))).warehouse = true;
				((WhatLevelIsVald)whatLevel.GetComponent(typeof(WhatLevelIsVald))).hotel = false;
				((WhatLevelIsVald)whatLevel.GetComponent(typeof(WhatLevelIsVald))).yard = false;
				((WhatLevelIsVald)whatLevel.GetComponent(typeof(WhatLevelIsVald))).swamp = false;
			}
		}
	}

	public virtual void Main()
	{
	}
}
