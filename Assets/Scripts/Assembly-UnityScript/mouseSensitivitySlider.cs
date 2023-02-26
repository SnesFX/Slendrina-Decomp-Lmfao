using System;
using UnityEngine;

[Serializable]
public class mouseSensitivitySlider : MonoBehaviour
{
	public float hSliderValue;

	public virtual void OnGUI()
	{
		hSliderValue = GUI.HorizontalSlider(new Rect(25f, 25f, 100f, 30f), hSliderValue, 0f, 10f);
	}

	public virtual void Main()
	{
	}
}
