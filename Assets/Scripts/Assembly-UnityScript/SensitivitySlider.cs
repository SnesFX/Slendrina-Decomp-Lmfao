using System;
using UnityEngine;

[Serializable]
public class SensitivitySlider : MonoBehaviour
{
	public float hSliderValue;

	public GUIStyle style;

	public GUIStyle style1;

	private Rect defaultRect;

	private GUITexture gui;

	public GameObject savedValue;

	public virtual void Start()
	{
		if (SaveSensitivityData.sliderValue > 5f || !(SaveSensitivityData.sliderValue >= 5f))
		{
			hSliderValue = SaveSensitivityData.sliderValue;
		}
		else
		{
			hSliderValue = 5f;
		}
	}

	public virtual void Update()
	{
		GameObject gameObject = GameObject.Find("Player");
		MouseLook mouseLook = (MouseLook)gameObject.GetComponent(typeof(MouseLook));
		GameObject gameObject2 = GameObject.Find("Main Camera");
		MouseLook mouseLook2 = (MouseLook)gameObject2.GetComponent(typeof(MouseLook));
		mouseLook.sensitivityX = hSliderValue;
		mouseLook2.sensitivityY = hSliderValue;
		SaveSensitivityData.sliderValue = hSliderValue;
	}

	public virtual void OnGUI()
	{
		int width = Screen.width;
		int height = Screen.height;
		GUI.skin.horizontalSlider = style;
		GUI.skin.horizontalSliderThumb = style1;
		hSliderValue = GUI.HorizontalSlider(new Rect((float)(width / 2) * 0.69f, (float)height / 2.8f, (float)(width / 2) * 0.60732985f, (float)(height / 2) * (17f / 166f)), hSliderValue, 0.1f, 20f);
	}

	public virtual void Main()
	{
	}
}
