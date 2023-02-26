using System;
using UnityEngine;

[Serializable]
public class WebLink : MonoBehaviour
{
	public virtual void Update()
	{
		int i = 0;
		Touch[] touches = Input.touches;
		for (int length = touches.Length; i < length; i++)
		{
			if (touches[i].phase == TouchPhase.Ended && GetComponent<GUITexture>().HitTest(touches[i].position))
			{
				Application.OpenURL("http://play.google.com/store/apps/details?id=com.dvloper.slendrina");
			}
		}
	}

	public virtual void Main()
	{
	}
}
