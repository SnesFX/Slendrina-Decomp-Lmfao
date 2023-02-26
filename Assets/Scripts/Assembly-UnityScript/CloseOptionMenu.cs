using System;
using UnityEngine;

[Serializable]
public class CloseOptionMenu : MonoBehaviour
{
	public GameObject optionMenu;

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
				Time.timeScale = 1f;
				optionMenu.SetActive(false);
			}
		}
	}

	public virtual void Main()
	{
	}
}
