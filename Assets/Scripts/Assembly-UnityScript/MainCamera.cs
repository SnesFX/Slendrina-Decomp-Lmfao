using System;
using UnityEngine;

[Serializable]
public class MainCamera : MonoBehaviour
{
	[NonSerialized]
	private static int FULLSCREEN_SWIPE_ROTATION = 100;

	private Vector2 startingTouchPosition;

	private Vector2 startingTouchPercent;

	private Vector3 startingCameraPosition;

	private Quaternion startingCameraRotation;

	public Transform target;

	public float distance;

	public float rotateSpeed;

	public int yMinLimit;

	public int yMaxLimit;

	public int zoomRate;

	public float panSpeed;

	public float zoomDampening;

	private float xDeg;

	private float yDeg;

	private float currentDistance;

	private float desiredDistance;

	private Quaternion currentRotation;

	private Quaternion desiredRotation;

	private Quaternion rotation;

	private Vector3 position;

	private Transform thisTransform;

	private RaycastHit hit;

	public MainCamera()
	{
		rotateSpeed = 100f;
		yMinLimit = -180;
		yMaxLimit = 180;
		zoomRate = 40;
		panSpeed = 0.3f;
		zoomDampening = 5f;
		currentDistance = 1f;
	}

	public virtual void Start()
	{
		Init();
	}

	public virtual void OnEnable()
	{
		Init();
	}

	public virtual void Init()
	{
		currentDistance = distance;
		desiredDistance = distance;
		position = transform.position;
		rotation = transform.rotation;
		currentRotation = transform.rotation;
		desiredRotation = transform.rotation;
		xDeg = Vector3.Angle(Vector3.right, transform.right);
		yDeg = Vector3.Angle(Vector3.up, transform.up);
	}

	public virtual void LateUpdate()
	{
		HandleTouchEvents();
	}

	private void HandleTouchEvents()
	{
		RotateCamera();
	}

	private void RotateCamera()
	{
		int touchCount = Input.touchCount;
		for (int i = 0; i < touchCount; i++)
		{
			if (Input.touchCount > 0)
			{
				int fingerId = Input.GetTouch(i).fingerId;
				int touchCount2 = Input.touchCount;
				Touch touch = Input.GetTouch(0);
				if (Input.touchCount > 0 && !(touch.position.x <= (float)(Screen.width / 2)))
				{
					xDeg += Input.GetTouch(0).deltaPosition.x * rotateSpeed * Time.deltaTime;
					yDeg -= Input.GetTouch(0).deltaPosition.y * rotateSpeed * Time.deltaTime;
					yDeg = Mathf.Clamp(yDeg, -45f, 45f);
					desiredRotation = Quaternion.Euler(yDeg, xDeg, 0f);
					currentRotation = transform.rotation;
					target.rotation = Quaternion.Lerp(currentRotation, desiredRotation, Time.deltaTime * zoomDampening);
					transform.rotation = target.rotation;
					position = target.position - rotation * Vector3.forward * currentDistance;
					transform.position = position;
				}
			}
		}
	}

	private void SaveStartingOrientation(Touch firstTouch)
	{
		startingCameraPosition = transform.position;
		startingCameraRotation = transform.rotation;
		startingTouchPosition = firstTouch.position;
		Debug.Log(startingTouchPercent);
	}
}
