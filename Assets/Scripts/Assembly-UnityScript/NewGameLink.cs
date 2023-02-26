using System;
using UnityEngine;

[Serializable]
public class NewGameLink : MonoBehaviour
{
	public virtual void Update()
	{
		int i = 0;
		Touch[] touches = Input.touches;
		for (int length = touches.Length; i < length; i++)
		{
			if (touches[i].phase == TouchPhase.Ended && GetComponent<GUITexture>().HitTest(touches[i].position))
			{
				Application.OpenURL("http://play.google.com/store/apps/developer?id=DVloper");
			}
		}
	}

	public virtual void Main()
	{
	}
}
