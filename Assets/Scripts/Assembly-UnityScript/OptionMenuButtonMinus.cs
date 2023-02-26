using System;
using UnityEngine;

[Serializable]
public class OptionMenuButtonMinus : MonoBehaviour
{
	public GameObject sensitivityHolder;

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
				((SensitivityController)sensitivityHolder.GetComponent(typeof(SensitivityController))).CountDown();
			}
		}
	}

	public virtual void Main()
	{
	}
}
