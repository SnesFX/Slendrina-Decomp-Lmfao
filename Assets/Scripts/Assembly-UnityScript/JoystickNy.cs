using System;
using UnityEngine;

[Serializable]
public class JoystickNy : MonoBehaviour
{
	public float speed;

	public Transform player;

	public float pitch;

	public float yaw;

	[NonSerialized]
	public static int currTouch;

	public int touches;

	private Vector3 oRotation;

	public JoystickNy()
	{
		speed = 0.1f;
	}

	public virtual void Start()
	{
		oRotation = player.eulerAngles;
		pitch = oRotation.x;
		yaw = oRotation.y;
	}

	public virtual void Update()
	{
		if (Input.touchCount <= 0)
		{
			return;
		}
		for (int i = 0; i < Input.touchCount; i++)
		{
			currTouch = i;
			if (!GetComponent<GUITexture>().HitTest(Input.GetTouch(i).position))
			{
				continue;
			}
			if (Input.GetTouch(i).phase == TouchPhase.Began)
			{
				touches = currTouch;
			}
			if (Input.GetTouch(i).phase == TouchPhase.Moved)
			{
				pitch -= Input.GetTouch(touches).deltaPosition.y * speed * Time.deltaTime;
				yaw += Input.GetTouch(touches).deltaPosition.x * speed * Time.deltaTime;
				pitch = Mathf.Clamp(pitch, -30f, 30f);
				player.eulerAngles = new Vector3(pitch, yaw, 0f);
				if (Input.GetTouch(i).phase != TouchPhase.Ended)
				{
				}
			}
		}
	}

	public virtual void joystickTouch()
	{
	}

	public virtual void joystickTouchNot()
	{
		touches = 0;
	}

	public virtual void Main()
	{
	}
}
