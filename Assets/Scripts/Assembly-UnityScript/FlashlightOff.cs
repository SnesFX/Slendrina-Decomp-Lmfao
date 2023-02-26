using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class FlashlightOff : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024flickerLight_0024343 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal FlashlightOff _0024self__0024344;

			public _0024(FlashlightOff self_)
			{
				_0024self__0024344 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					((soundEffects)_0024self__0024344.soundHolder.GetComponent(typeof(soundEffects))).flickerLight();
					_0024self__0024344.playerFlashlight.SetActive(false);
					result = (Yield(2, new WaitForSeconds(0.1f)) ? 1 : 0);
					break;
				case 2:
					_0024self__0024344.playerFlashlight.SetActive(true);
					result = (Yield(3, new WaitForSeconds(0.1f)) ? 1 : 0);
					break;
				case 3:
					_0024self__0024344.playerFlashlight.SetActive(false);
					result = (Yield(4, new WaitForSeconds(0.1f)) ? 1 : 0);
					break;
				case 4:
					_0024self__0024344.playerFlashlight.SetActive(true);
					result = (Yield(5, new WaitForSeconds(0.1f)) ? 1 : 0);
					break;
				case 5:
					_0024self__0024344.playerFlashlight.SetActive(false);
					result = (Yield(6, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 6:
					((soundEffects)_0024self__0024344.soundHolder.GetComponent(typeof(soundEffects))).lightButton();
					((soundEffects)_0024self__0024344.soundHolder.GetComponent(typeof(soundEffects))).SlendrinaBreath();
					result = (Yield(7, new WaitForSeconds(2.7f)) ? 1 : 0);
					break;
				case 7:
					_0024self__0024344.StartCoroutine(_0024self__0024344.LightOn());
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal FlashlightOff _0024self__0024345;

		public _0024flickerLight_0024343(FlashlightOff self_)
		{
			_0024self__0024345 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__0024345);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024LightOn_0024346 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal FlashlightOff _0024self__0024347;

			public _0024(FlashlightOff self_)
			{
				_0024self__0024347 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (((_0024self__0024347.number != 1) ? Yield(5, new WaitForSeconds(1.5f)) : Yield(2, new WaitForSeconds(1.5f))) ? 1 : 0);
					break;
				case 2:
					_0024self__0024347.playerFlashlight2.SetActive(true);
					_0024self__0024347.face.SetActive(true);
					((soundEffects)_0024self__0024347.soundHolder.GetComponent(typeof(soundEffects))).slendrinaFace();
					((soundEffects)_0024self__0024347.soundHolder.GetComponent(typeof(soundEffects))).flashlightButton();
					result = (Yield(3, new WaitForSeconds(3.7f)) ? 1 : 0);
					break;
				case 3:
					_0024self__0024347.face.SetActive(false);
					((soundEffects)_0024self__0024347.soundHolder.GetComponent(typeof(soundEffects))).flashlightButton();
					_0024self__0024347.playerFlashlight2.SetActive(false);
					result = (Yield(4, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 4:
					((soundEffects)_0024self__0024347.soundHolder.GetComponent(typeof(soundEffects))).flashlightButton();
					_0024self__0024347.playerFlashlight.SetActive(true);
					_0024self__0024347.playerScript.GetComponent<FPSInputController>().enabled = true;
					_0024self__0024347.playerScript.GetComponent<MouseLook>().enabled = true;
					_0024self__0024347.mouseLook.GetComponent<MouseLook>().enabled = true;
					((checkOngoing)_0024self__0024347.gameController.GetComponent(typeof(checkOngoing))).onGoing = false;
					Cursor.visible = false;
					Screen.lockCursor = true;
					UnityEngine.Object.Destroy(_0024self__0024347.gameObject);
					goto IL_02d5;
				case 5:
					_0024self__0024347.playerFlashlight.SetActive(true);
					_0024self__0024347.playerScript.GetComponent<FPSInputController>().enabled = true;
					_0024self__0024347.playerScript.GetComponent<MouseLook>().enabled = true;
					_0024self__0024347.mouseLook.GetComponent<MouseLook>().enabled = true;
					((soundEffects)_0024self__0024347.soundHolder.GetComponent(typeof(soundEffects))).flashlightButton();
					((soundEffects)_0024self__0024347.soundHolder.GetComponent(typeof(soundEffects))).BoomSound();
					((checkOngoing)_0024self__0024347.gameController.GetComponent(typeof(checkOngoing))).onGoing = false;
					Cursor.visible = false;
					Screen.lockCursor = true;
					UnityEngine.Object.Destroy(_0024self__0024347.gameObject);
					goto IL_02d5;
				case 1:
					{
						result = 0;
						break;
					}
					IL_02d5:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal FlashlightOff _0024self__0024348;

		public _0024LightOn_0024346(FlashlightOff self_)
		{
			_0024self__0024348 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__0024348);
		}
	}

	public GameObject soundHolder;

	public GameObject animationHolder;

	public GameObject face;

	public GameObject playerFlashlight;

	public GameObject playerFlashlight2;

	public GameObject playerScript;

	public GameObject mouseLook;

	public GameObject gameController;

	public int number;

	public virtual void Start()
	{
		number = UnityEngine.Random.Range(1, 3);
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			((checkOngoing)gameController.GetComponent(typeof(checkOngoing))).onGoing = true;
			animationHolder.GetComponent<Animation>().Stop("HeadBobAnimation");
			playerScript.GetComponent<FPSInputController>().enabled = false;
			playerScript.GetComponent<MouseLook>().enabled = false;
			mouseLook.GetComponent<MouseLook>().enabled = false;
			((Footsteps)playerScript.GetComponent(typeof(Footsteps))).GetComponent<AudioSource>().Stop();
			StartCoroutine(flickerLight());
		}
	}

	public virtual IEnumerator flickerLight()
	{
		return new _0024flickerLight_0024343(this).GetEnumerator();
	}

	public virtual IEnumerator LightOn()
	{
		return new _0024LightOn_0024346(this).GetEnumerator();
	}

	public virtual void Main()
	{
	}
}
