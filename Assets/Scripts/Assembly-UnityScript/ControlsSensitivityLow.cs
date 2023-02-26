using System;
using UnityEngine;

[Serializable]
public class ControlsSensitivityLow : MonoBehaviour
{
	public GUITexture lowButton;

	public GUITexture mediumButton;

	public GUITexture highButton;

	public Texture2D lowButtonActive;

	public Texture2D mediumButtonActive;

	public Texture2D highButtonActive;

	public Texture2D lowButtonInActive;

	public Texture2D mediumButtonInActive;

	public Texture2D highButtonInActive;

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
				lowButton.texture = lowButtonActive;
				mediumButton.texture = mediumButtonInActive;
				highButton.texture = highButtonInActive;
				((SwipeScript)sensitivityHolder.GetComponent(typeof(SwipeScript))).speed = 10f;
			}
		}
	}

	public virtual void Main()
	{
	}
}
