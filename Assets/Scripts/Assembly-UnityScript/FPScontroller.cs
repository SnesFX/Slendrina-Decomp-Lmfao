using System;
using UnityEngine;

[Serializable]
[RequireComponent(typeof(CharacterController))]
public class FPScontroller : MonoBehaviour
{
	public Joystick moveTouchPad;

	public Joystick rotateTouchPad;

	public Transform cameraPivot;

	public float forwardSpeed;

	public float backwardSpeed;

	public float sidestepSpeed;

	public float jumpSpeed;

	public float inAirMultiplier;

	public Vector2 rotationSpeed;

	public float tiltPositiveYAxis;

	public float tiltNegativeYAxis;

	public float tiltXAxisMinimum;

	private Transform thisTransform;

	private CharacterController character;

	private Vector3 cameraVelocity;

	private Vector3 velocity;

	private bool canJump;

	public GameObject rotateControll;

	public GameObject footstepScriptHolder;

	public FPScontroller()
	{
		forwardSpeed = 4f;
		backwardSpeed = 1f;
		sidestepSpeed = 1f;
		jumpSpeed = 8f;
		inAirMultiplier = 0.25f;
		rotationSpeed = new Vector2(50f, 25f);
		tiltPositiveYAxis = 0.6f;
		tiltNegativeYAxis = 0.4f;
		tiltXAxisMinimum = 0.1f;
		canJump = true;
	}

	public virtual void Start()
	{
		thisTransform = (Transform)GetComponent(typeof(Transform));
		character = (CharacterController)GetComponent(typeof(CharacterController));
		GameObject gameObject = GameObject.Find("PlayerSpawn");
		if ((bool)gameObject)
		{
			thisTransform.position = gameObject.transform.position;
		}
	}

	public virtual void OnEndGame()
	{
		moveTouchPad.Disable();
		if ((bool)rotateTouchPad)
		{
			rotateTouchPad.Disable();
		}
		enabled = false;
	}

	public virtual void Update()
	{
		Vector3 motion = thisTransform.TransformDirection(new Vector3(moveTouchPad.position.x, 0f, moveTouchPad.position.y));
		motion.y = 0f;
		motion.Normalize();
		Vector2 vector = new Vector2(Mathf.Abs(moveTouchPad.position.x), Mathf.Abs(moveTouchPad.position.y));
		if (!(vector.y <= vector.x))
		{
			((SwipeScript)rotateControll.GetComponent(typeof(SwipeScript))).joystickTouch();
			((Footsteps)footstepScriptHolder.GetComponent(typeof(Footsteps))).walk();
			if (!(moveTouchPad.position.y <= 0f))
			{
				motion *= forwardSpeed;
			}
			else
			{
				motion *= backwardSpeed;
			}
		}
		else if (!(vector.y >= vector.x))
		{
			motion *= sidestepSpeed;
			((Footsteps)footstepScriptHolder.GetComponent(typeof(Footsteps))).walk();
		}
		else
		{
			((SwipeScript)rotateControll.GetComponent(typeof(SwipeScript))).joystickTouchNot();
			((Footsteps)footstepScriptHolder.GetComponent(typeof(Footsteps))).stopwalk();
		}
		motion += velocity;
		motion += Physics.gravity;
		motion *= Time.deltaTime;
		character.Move(motion);
		if (character.isGrounded)
		{
			velocity = Vector3.zero;
		}
		if (character.isGrounded)
		{
			Vector2 vector2 = Vector2.zero;
			if ((bool)rotateTouchPad)
			{
				vector2 = rotateTouchPad.position;
			}
			vector2.x *= rotationSpeed.x;
			vector2.y *= rotationSpeed.y;
			vector2 *= Time.deltaTime;
			thisTransform.Rotate(0f, vector2.x, 0f, Space.World);
			cameraPivot.Rotate(0f - vector2.y, 0f, 0f);
		}
	}

	public virtual void Main()
	{
	}
}
