using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class OpenDoor : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024lockedText_0024357 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal OpenDoor _0024self__0024358;

			public _0024(OpenDoor self_)
			{
				_0024self__0024358 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(3f)) ? 1 : 0);
					break;
				case 2:
					_0024self__0024358.doorLockedText.SetActive(false);
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal OpenDoor _0024self__0024359;

		public _0024lockedText_0024357(OpenDoor self_)
		{
			_0024self__0024359 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__0024359);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024moreBooks_0024360 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal OpenDoor _0024self__0024361;

			public _0024(OpenDoor self_)
			{
				_0024self__0024361 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(3f)) ? 1 : 0);
					break;
				case 2:
					_0024self__0024361.needMoreBooks.SetActive(false);
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal OpenDoor _0024self__0024362;

		public _0024moreBooks_0024360(OpenDoor self_)
		{
			_0024self__0024362 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__0024362);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024end_0024363 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal OpenDoor _0024self__0024364;

			public _0024(OpenDoor self_)
			{
				_0024self__0024364 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__0024364.stopSlendrina.SetActive(false);
					_0024self__0024364.player.SetActive(false);
					_0024self__0024364.slendrinaEnd.SetActive(true);
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal OpenDoor _0024self__0024365;

		public _0024end_0024363(OpenDoor self_)
		{
			_0024self__0024365 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__0024365);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024usedOneKey_0024366 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal OpenDoor _0024self__0024367;

			public _0024(OpenDoor self_)
			{
				_0024self__0024367 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(3f)) ? 1 : 0);
					break;
				case 2:
					_0024self__0024367.keyUsedText.SetActive(false);
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal OpenDoor _0024self__0024368;

		public _0024usedOneKey_0024366(OpenDoor self_)
		{
			_0024self__0024368 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__0024368);
		}
	}

	public AudioClip Doorljud;

	public AudioClip cellarDoorljud;

	public AudioClip gardeDoorljud;

	public AudioClip DoorLockedljud;

	public AudioClip DoorUnLockedljud;

	public AudioClip prisonDoorUnLockedljud;

	public AudioClip steelDoorUnLockedljud;

	public AudioClip finDoorUnLockedljud;

	public GameObject scriptHolder;

	public GameObject scriptHolderCounter;

	public GameObject doorLockedText;

	public GameObject youMadeItText;

	public GameObject stopMovement;

	public GameObject touchArea;

	public GameObject needMoreBooks;

	public GameObject fadeBlack;

	public AudioClip endLjud;

	public GameObject animationHolder;

	public GameObject stopSlendrina;

	public GameObject keyUsedText;

	public GameObject player;

	public GameObject slendrinaEnd;

	public virtual void Update()
	{
		RaycastHit hitInfo = default(RaycastHit);
		for (int i = 0; i < Input.touchCount; i++)
		{
			if (Input.GetTouch(i).phase != 0)
			{
				continue;
			}
			Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
			if (!Physics.Raycast(ray, out hitInfo, 3f))
			{
				continue;
			}
			if (hitInfo.collider.gameObject.tag == "door")
			{
				AudioSource.PlayClipAtPoint(Doorljud, transform.position);
				hitInfo.collider.gameObject.GetComponent<Animation>().Play("openDoor");
			}
			else if (hitInfo.collider.gameObject.tag == "cellardoor")
			{
				AudioSource.PlayClipAtPoint(cellarDoorljud, transform.position);
				hitInfo.collider.gameObject.GetComponent<Animation>().Play("openDoor");
			}
			else if (hitInfo.collider.gameObject.tag == "doorlocked")
			{
				if (((CountKey)scriptHolder.GetComponent(typeof(CountKey))).keys > 0)
				{
					((CountKey)scriptHolder.GetComponent(typeof(CountKey))).countDownKey();
					AudioSource.PlayClipAtPoint(DoorUnLockedljud, transform.position);
					hitInfo.collider.gameObject.GetComponent<Animation>().Play("openDoor");
					keyUsedText.SetActive(true);
					StartCoroutine(usedOneKey());
				}
				else
				{
					doorLockedText.SetActive(true);
					AudioSource.PlayClipAtPoint(DoorLockedljud, transform.position);
					StartCoroutine(lockedText());
				}
			}
			else if (hitInfo.collider.gameObject.tag == "prisondoorlocked")
			{
				if (((CountKey)scriptHolder.GetComponent(typeof(CountKey))).keys > 0)
				{
					((CountKey)scriptHolder.GetComponent(typeof(CountKey))).countDownKey();
					AudioSource.PlayClipAtPoint(prisonDoorUnLockedljud, transform.position);
					hitInfo.collider.gameObject.GetComponent<Animation>().Play("openDoor");
					keyUsedText.SetActive(true);
					StartCoroutine(usedOneKey());
				}
				else
				{
					doorLockedText.SetActive(true);
					AudioSource.PlayClipAtPoint(DoorLockedljud, transform.position);
					StartCoroutine(lockedText());
				}
			}
			else if (hitInfo.collider.gameObject.tag == "steeldoorlocked")
			{
				if (((CountKey)scriptHolder.GetComponent(typeof(CountKey))).keys > 0)
				{
					((CountKey)scriptHolder.GetComponent(typeof(CountKey))).countDownKey();
					AudioSource.PlayClipAtPoint(steelDoorUnLockedljud, transform.position);
					hitInfo.collider.gameObject.GetComponent<Animation>().Play("openDoor");
					keyUsedText.SetActive(true);
					StartCoroutine(usedOneKey());
				}
				else
				{
					doorLockedText.SetActive(true);
					AudioSource.PlayClipAtPoint(DoorLockedljud, transform.position);
					StartCoroutine(lockedText());
				}
			}
			else if (hitInfo.collider.gameObject.tag == "findoorlocked")
			{
				if (((CountKey)scriptHolder.GetComponent(typeof(CountKey))).keys > 0)
				{
					((CountKey)scriptHolder.GetComponent(typeof(CountKey))).countDownKey();
					AudioSource.PlayClipAtPoint(finDoorUnLockedljud, transform.position);
					hitInfo.collider.gameObject.GetComponent<Animation>().Play("openDoor");
					keyUsedText.SetActive(true);
					StartCoroutine(usedOneKey());
				}
				else
				{
					doorLockedText.SetActive(true);
					AudioSource.PlayClipAtPoint(DoorLockedljud, transform.position);
					StartCoroutine(lockedText());
				}
			}
			else if (hitInfo.collider.gameObject.tag == "headdoor")
			{
				if (((Counter)scriptHolderCounter.GetComponent(typeof(Counter))).counter == 8f)
				{
					AudioSource.PlayClipAtPoint(endLjud, transform.position);
					hitInfo.collider.gameObject.tag = null;
					animationHolder.GetComponent<Animation>().Stop("HeadBobAnimation");
					((FPSControllerNEW)stopMovement.GetComponent(typeof(FPSControllerNEW))).enabled = false;
					touchArea.SetActive(false);
					StartCoroutine(end());
				}
				else
				{
					AudioSource.PlayClipAtPoint(DoorLockedljud, transform.position);
					needMoreBooks.SetActive(true);
					StartCoroutine(moreBooks());
				}
			}
			else if (hitInfo.collider.gameObject.tag == "gardeH")
			{
				AudioSource.PlayClipAtPoint(gardeDoorljud, transform.position);
				hitInfo.collider.gameObject.GetComponent<Animation>().Play("openH");
			}
			else if (hitInfo.collider.gameObject.tag == "gardeV")
			{
				AudioSource.PlayClipAtPoint(gardeDoorljud, transform.position);
				hitInfo.collider.gameObject.GetComponent<Animation>().Play("openV");
			}
		}
	}

	public virtual IEnumerator lockedText()
	{
		return new _0024lockedText_0024357(this).GetEnumerator();
	}

	public virtual IEnumerator moreBooks()
	{
		return new _0024moreBooks_0024360(this).GetEnumerator();
	}

	public virtual IEnumerator end()
	{
		return new _0024end_0024363(this).GetEnumerator();
	}

	public virtual IEnumerator usedOneKey()
	{
		return new _0024usedOneKey_0024366(this).GetEnumerator();
	}

	public virtual void Main()
	{
	}
}
