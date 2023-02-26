using System;
using UnityEngine;

[Serializable]
public class TestControls : MonoBehaviour
{
	public GUITexture gui;

	public bool pixelInsetPosResSet;

	public GameObject playerCharacter;

	public int leftID;

	public TestControls()
	{
		pixelInsetPosResSet = true;
	}

	public virtual void Start()
	{
		guiPixelInsetResSet();
		float a = 0.1f;
		Color color = gui.color;
		float num = (color.a = a);
		Color color3 = (gui.color = color);
		int num2 = 1;
		Vector3 position = gui.transform.position;
		float num3 = (position.z = num2);
		Vector3 vector2 = (gui.transform.position = position);
	}

	public virtual void JoystickGUIMove()
	{
		if (Input.touchCount <= 0)
		{
			return;
		}
		for (int i = 0; i < Input.touchCount; i++)
		{
			Touch touch = Input.GetTouch(i);
			if (touch.phase == TouchPhase.Began && GetComponent<GUITexture>().HitTest(touch.position))
			{
				leftID = Input.GetTouch(i).fingerId;
				pixelInsetPosResSet = false;
			}
			if (!pixelInsetPosResSet && Input.GetTouch(i).fingerId == leftID)
			{
				float num = touch.position.x + (float)Screen.width / -1.78f;
				Rect pixelInset = gui.pixelInset;
				float num3 = (pixelInset.x = num);
				Rect rect2 = (gui.pixelInset = pixelInset);
				float num4 = touch.position.y + (float)Screen.height / -1.63f;
				Rect pixelInset2 = gui.pixelInset;
				float num6 = (pixelInset2.y = num4);
				Rect rect4 = (gui.pixelInset = pixelInset2);
				float a = 0.5f;
				Color color = gui.color;
				float num7 = (color.a = a);
				Color color3 = (gui.color = color);
				if (!(gui.pixelInset.y <= (float)Screen.height / -3.5f))
				{
					float z = playerCharacter.transform.position.z + 8f * Time.deltaTime;
					Vector3 position = playerCharacter.transform.position;
					float num8 = (position.z = z);
					Vector3 vector2 = (playerCharacter.transform.position = position);
				}
				else if (!(gui.pixelInset.y <= (float)Screen.height / -2.6f))
				{
					float z2 = playerCharacter.transform.position.z + 2f * Time.deltaTime;
					Vector3 position2 = playerCharacter.transform.position;
					float num9 = (position2.z = z2);
					Vector3 vector4 = (playerCharacter.transform.position = position2);
				}
				else if (!(gui.pixelInset.y >= (float)Screen.height * -0.475f))
				{
					float z3 = playerCharacter.transform.position.z - 2f * Time.deltaTime;
					Vector3 position3 = playerCharacter.transform.position;
					float num10 = (position3.z = z3);
					Vector3 vector6 = (playerCharacter.transform.position = position3);
				}
				if (!(gui.pixelInset.x <= (float)Screen.width / -2.4f))
				{
					float x = playerCharacter.transform.position.x + 2f * Time.deltaTime;
					Vector3 position4 = playerCharacter.transform.position;
					float num11 = (position4.x = x);
					Vector3 vector8 = (playerCharacter.transform.position = position4);
				}
				if (!(gui.pixelInset.x <= (float)Screen.width / -2.4f) && !(gui.pixelInset.y <= (float)Screen.height / -3.5f))
				{
					float x2 = playerCharacter.transform.position.x + 5f * Time.deltaTime;
					Vector3 position5 = playerCharacter.transform.position;
					float num12 = (position5.x = x2);
					Vector3 vector10 = (playerCharacter.transform.position = position5);
				}
				if (!(gui.pixelInset.x >= (float)Screen.width / -2.1f))
				{
					float x3 = playerCharacter.transform.position.x - 2f * Time.deltaTime;
					Vector3 position6 = playerCharacter.transform.position;
					float num13 = (position6.x = x3);
					Vector3 vector12 = (playerCharacter.transform.position = position6);
				}
				if (!(gui.pixelInset.x >= (float)Screen.width / -2.1f) && !(gui.pixelInset.y <= (float)Screen.height / -3.5f))
				{
					float x4 = playerCharacter.transform.position.x - 5f * Time.deltaTime;
					Vector3 position7 = playerCharacter.transform.position;
					float num14 = (position7.x = x4);
					Vector3 vector14 = (playerCharacter.transform.position = position7);
				}
				if (!pixelInsetPosResSet)
				{
					if (!(touch.position.y + (float)Screen.height / -1.63f <= (float)Screen.height / -4.5f))
					{
						float num15 = (float)Screen.height / -4.5f;
						Rect pixelInset3 = gui.pixelInset;
						float num17 = (pixelInset3.y = num15);
						Rect rect6 = (gui.pixelInset = pixelInset3);
					}
					if (!(touch.position.y + (float)Screen.height / -1.63f >= (float)Screen.height * -0.5f))
					{
						float num18 = (float)Screen.height * -0.5f;
						Rect pixelInset4 = gui.pixelInset;
						float num20 = (pixelInset4.y = num18);
						Rect rect8 = (gui.pixelInset = pixelInset4);
					}
					if (!(touch.position.x + (float)Screen.width / -1.78f <= (float)Screen.width / -2.6f))
					{
						float num21 = (float)Screen.width / -2.6f;
						Rect pixelInset5 = gui.pixelInset;
						float num23 = (pixelInset5.x = num21);
						Rect rect10 = (gui.pixelInset = pixelInset5);
					}
					if (!(touch.position.x + (float)Screen.width / -1.78f >= (float)Screen.width * -0.5f))
					{
						float num24 = (float)Screen.width * -0.5f;
						Rect pixelInset6 = gui.pixelInset;
						float num26 = (pixelInset6.x = num24);
						Rect rect12 = (gui.pixelInset = pixelInset6);
					}
				}
				else
				{
					pixelInsetPosResSet = true;
					pixelInsetPositionReset();
				}
			}
			pixelInsetPositionReset();
		}
	}

	public virtual void pixelInsetPositionReset()
	{
		for (int i = 0; i < Input.touchCount; i++)
		{
			if (Input.GetTouch(i).phase == TouchPhase.Ended)
			{
				pixelInsetPosResSet = true;
				guiPixelInsetResSet();
			}
		}
	}

	public virtual void guiPixelInsetResSet()
	{
		if (pixelInsetPosResSet)
		{
			float num = (float)Screen.width / 8.5f;
			Rect pixelInset = gui.pixelInset;
			float num3 = (pixelInset.width = num);
			Rect rect2 = (gui.pixelInset = pixelInset);
			float width = gui.pixelInset.width;
			Rect pixelInset2 = gui.pixelInset;
			float num5 = (pixelInset2.height = width);
			Rect rect4 = (gui.pixelInset = pixelInset2);
			float num6 = (float)Screen.width / -2.25f;
			Rect pixelInset3 = gui.pixelInset;
			float num8 = (pixelInset3.x = num6);
			Rect rect6 = (gui.pixelInset = pixelInset3);
			float num9 = (float)Screen.height / -2.35f;
			Rect pixelInset4 = gui.pixelInset;
			float num11 = (pixelInset4.y = num9);
			Rect rect8 = (gui.pixelInset = pixelInset4);
		}
	}

	public virtual void Update()
	{
		pixelInsetPositionReset();
		float a = 0.1f;
		Color color = gui.color;
		float num = (color.a = a);
		Color color3 = (gui.color = color);
		JoystickGUIMove();
	}

	public virtual void Main()
	{
	}
}
