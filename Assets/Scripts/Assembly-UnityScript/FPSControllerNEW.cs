using System;
using UnityEngine;

[Serializable]
[RequireComponent(typeof(CharacterController))]
public class FPSControllerNEW : MonoBehaviour
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

	public GameObject headBobAnimHolder;

	public FPSControllerNEW()
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
			if (!(moveTouchPad.position.y <= -0.3f) && !(moveTouchPad.position.y >= 0.4f))
			{
				motion *= forwardSpeed * vector.y;
				footstepScriptHolder.GetComponent<AudioSource>().pitch = 0.6f;
				headBobAnimHolder.GetComponent<Animation>()["HeadBobAnimation"].speed = 0.6f;
			}
			else if (!(moveTouchPad.position.y < 0.4f) && !(moveTouchPad.position.y >= 0.8f))
			{
				motion *= forwardSpeed * vector.y;
				footstepScriptHolder.GetComponent<AudioSource>().pitch = 0.7f;
				headBobAnimHolder.GetComponent<Animation>()["HeadBobAnimation"].speed = 0.7f;
			}
			else if (!(moveTouchPad.position.y < 0.8f) && !(moveTouchPad.position.y >= 1.5f))
			{
				motion *= forwardSpeed * vector.y;
				footstepScriptHolder.GetComponent<AudioSource>().pitch = 1f;
				headBobAnimHolder.GetComponent<Animation>()["HeadBobAnimation"].speed = 1f;
			}
			else if (!(moveTouchPad.position.y <= -1.5f) && !(moveTouchPad.position.y >= -0.3f))
			{
				motion *= backwardSpeed * vector.y;
				footstepScriptHolder.GetComponent<AudioSource>().pitch = 0.6f;
				headBobAnimHolder.GetComponent<Animation>()["HeadBobAnimation"].speed = 0.6f;
			}
		}
		else if (!(vector.y >= vector.x))
		{
			motion *= sidestepSpeed * vector.x;
			footstepScriptHolder.GetComponent<AudioSource>().pitch = 0.7f;
			headBobAnimHolder.GetComponent<Animation>()["HeadBobAnimation"].speed = 0.7f;
		}
		else if (vector.y != 1f && moveTouchPad.position.y == 0f)
		{
			((Footsteps)footstepScriptHolder.GetComponent(typeof(Footsteps))).stopwalk();
		}
		if (character.isGrounded)
		{
			bool flag = false;
			Joystick joystick = null;
			joystick = ((!rotateTouchPad) ? moveTouchPad : rotateTouchPad);
			if (!joystick.IsFingerDown())
			{
				canJump = true;
			}
			if (canJump && joystick.tapCount >= 2)
			{
				flag = true;
				canJump = false;
			}
			if (flag)
			{
				velocity = character.velocity;
				velocity.y = jumpSpeed;
			}
		}
		else
		{
			velocity.y += Physics.gravity.y * Time.deltaTime;
			motion.x *= inAirMultiplier;
			motion.z *= inAirMultiplier;
		}
		motion += velocity;
		motion += Physics.gravity;
		motion *= Time.deltaTime;
		character.Move(motion);
		if (character.isGrounded)
		{
			velocity = Vector3.zero;
		}
		if (!character.isGrounded)
		{
			return;
		}
		Vector2 vector2 = Vector2.zero;
		if ((bool)rotateTouchPad)
		{
			vector2 = rotateTouchPad.position;
		}
		else
		{
			Vector3 acceleration = Input.acceleration;
			float num = Mathf.Abs(acceleration.x);
			if (!(acceleration.z >= 0f) && !(acceleration.x >= 0f))
			{
				if (!(num < tiltPositiveYAxis))
				{
					vector2.y = (num - tiltPositiveYAxis) / (1f - tiltPositiveYAxis);
				}
				else if (!(num > tiltNegativeYAxis))
				{
					vector2.y = (0f - (tiltNegativeYAxis - num)) / tiltNegativeYAxis;
				}
			}
			if (!(Mathf.Abs(acceleration.y) < tiltXAxisMinimum))
			{
				vector2.x = (0f - (acceleration.y - tiltXAxisMinimum)) / (1f - tiltXAxisMinimum);
			}
		}
		vector2.x *= rotationSpeed.x;
		vector2.y *= rotationSpeed.y;
		vector2 *= Time.deltaTime;
		thisTransform.Rotate(0f, vector2.x, 0f, Space.World);
		cameraPivot.Rotate(0f - vector2.y, 0f, 0f);
	}

	public virtual void Main()
	{
	}
}