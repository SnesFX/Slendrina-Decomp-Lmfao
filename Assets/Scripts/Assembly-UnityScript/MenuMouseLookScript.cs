using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class MenuMouseLookScript : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024FadeAndLoadLevel_0024472 : GenericGenerator<object>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<object>, IEnumerator
		{
			internal float _0024fadeAmt_0024473;

			internal float _0024_0024266_0024474;

			internal Color _0024_0024267_0024475;

			internal string _0024theLevel_0024476;

			internal MenuMouseLookScript _0024self__0024477;

			public _0024(string theLevel, MenuMouseLookScript self_)
			{
				_0024theLevel_0024476 = theLevel;
				_0024self__0024477 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__0024477.isFading = true;
					goto case 2;
				case 2:
					if (_0024self__0024477.timer < _0024self__0024477.fadeTime)
					{
						_0024self__0024477.timer += Time.deltaTime;
						_0024fadeAmt_0024473 = _0024self__0024477.timer / _0024self__0024477.fadeTime;
						float num = (_0024_0024266_0024474 = _0024fadeAmt_0024473);
						Color color = (_0024_0024267_0024475 = _0024self__0024477.fadeObject.material.color);
						float num2 = (_0024_0024267_0024475.a = _0024_0024266_0024474);
						Color color3 = (_0024self__0024477.fadeObject.material.color = _0024_0024267_0024475);
						result = (YieldDefault(2) ? 1 : 0);
						break;
					}
					Application.LoadLevel(_0024theLevel_0024476);
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal string _0024theLevel_0024478;

		internal MenuMouseLookScript _0024self__0024479;

		public _0024FadeAndLoadLevel_0024472(string theLevel, MenuMouseLookScript self_)
		{
			_0024theLevel_0024478 = theLevel;
			_0024self__0024479 = self_;
		}

		public override IEnumerator<object> GetEnumerator()
		{
			return new _0024(_0024theLevel_0024478, _0024self__0024479);
		}
	}

	public float xSpeed;

	public float ySpeed;

	public float xMinLimit;

	public float xMaxLimit;

	public float yMinLimit;

	public float yMaxLimit;

	private float rotX;

	private float rotY;

	private float rotZ;

	private Transform cameraTransform;

	private GameObject lastHitObject;

	public Color selectedColour;

	public Color deselectedColour;

	public Vector3 lastMousePos;

	public Renderer fadeObject;

	public bool isFading;

	public float fadeTime;

	private float timer;

	public MenuMouseLookScript()
	{
		xSpeed = 1f;
		ySpeed = 1f;
		xMinLimit = -55f;
		xMaxLimit = 55f;
		yMinLimit = -35f;
		yMaxLimit = 25f;
		fadeTime = 1.5f;
	}

	public virtual void Start()
	{
		cameraTransform = transform;
		rotX = (rotY = (rotZ = 0f));
		cameraTransform.localRotation = Quaternion.identity;
		lastMousePos = Input.mousePosition;
		if (!fadeObject)
		{
			Debug.LogWarning("No paper Display Object in the Inspector");
			fadeObject = GameObject.Find("FadeObject").GetComponent<Renderer>();
		}
		float a = 0f;
		Color color = fadeObject.material.color;
		float num = (color.a = a);
		Color color3 = (fadeObject.material.color = color);
	}

	public virtual void Update()
	{
		if (isFading)
		{
			return;
		}
		RaycastHit hitInfo = default(RaycastHit);
		if (Physics.Raycast(cameraTransform.position, cameraTransform.forward, out hitInfo, 100f))
		{
			if (hitInfo.collider.gameObject.tag == "Player")
			{
				if ((bool)lastHitObject)
				{
					if (lastHitObject.name != hitInfo.collider.gameObject.name)
					{
						lastHitObject.GetComponent<Renderer>().material.color = deselectedColour;
						lastHitObject = hitInfo.collider.gameObject;
						lastHitObject.GetComponent<Renderer>().material.color = selectedColour;
					}
				}
				else
				{
					lastHitObject = hitInfo.collider.gameObject;
					lastHitObject.GetComponent<Renderer>().material.color = selectedColour;
				}
				if (Input.GetMouseButtonDown(0))
				{
					switch (hitInfo.collider.gameObject.name)
					{
					case "BtnMainMenu":
						StartCoroutine(FadeAndLoadLevel("SceneMainMenu"));
						break;
					case "BtnOptions":
						Debug.Log("No OPTIONS menu yet !");
						break;
					case "BtnPlay":
						StartCoroutine(FadeAndLoadLevel("GAME"));
						break;
					case "BtnQuit":
						Application.Quit();
						break;
					}
				}
			}
			else if ((bool)lastHitObject)
			{
				lastHitObject.GetComponent<Renderer>().material.color = deselectedColour;
				lastHitObject = null;
			}
		}
		else if ((bool)lastHitObject)
		{
			lastHitObject.GetComponent<Renderer>().material.color = deselectedColour;
			lastHitObject = null;
		}
	}

	public virtual void LateUpdate()
	{
		rotY += Input.GetAxis("Mouse X") * xSpeed;
		rotX -= Input.GetAxis("Mouse Y") * ySpeed;
		rotY = ClampRotation(rotY, xMinLimit, xMaxLimit);
		rotX = ClampRotation(rotX, 0f - yMaxLimit, 0f - yMinLimit);
		cameraTransform.localRotation = Quaternion.Euler(rotX, rotY, rotZ);
	}

	public virtual IEnumerator FadeAndLoadLevel(string theLevel)
	{
		return new _0024FadeAndLoadLevel_0024472(theLevel, this).GetEnumerator();
	}

	public virtual float ClampRotation(float theRot, float minRot, float maxRot)
	{
		if (!(theRot >= -360f))
		{
			theRot += 360f;
		}
		else if (!(theRot <= 360f))
		{
			theRot -= 360f;
		}
		theRot = Mathf.Clamp(theRot, minRot, maxRot);
		return theRot;
	}

	public virtual void Main()
	{
	}
}
