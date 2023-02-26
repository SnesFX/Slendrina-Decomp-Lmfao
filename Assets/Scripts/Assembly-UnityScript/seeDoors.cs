using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class seeDoors : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024end_0024397 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal seeDoors _0024self__0024398;

			public _0024(seeDoors self_)
			{
				_0024self__0024398 = self_;
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
					_0024self__0024398.keyHolder2.SetActive(false);
					_0024self__0024398.stopSlendrina.SetActive(false);
					_0024self__0024398.playerScript.SetActive(false);
					_0024self__0024398.slendrinaEnd.SetActive(true);
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal seeDoors _0024self__0024399;

		public _0024end_0024397(seeDoors self_)
		{
			_0024self__0024399 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__0024399);
		}
	}

	public GameObject doorE;

	public bool canopenDoor;

	public GameObject keyHolder;

	public GameObject keyHolder2;

	public GameObject bookCounter;

	public AudioClip DoorUnLockedljud;

	public AudioClip DoorLockedljud;

	public AudioClip prisonDoorUnLockedljud;

	public AudioClip steelDoorUnLockedljud;

	public AudioClip finDoorUnLockedljud;

	public AudioClip Doorljud;

	public AudioClip CellarDoorljud;

	public AudioClip garderobLjud;

	public GameObject keyUsedText;

	public GameObject doorLockedText;

	public GameObject firstFind8BooksText;

	public GameObject playerScript;

	public GameObject mouseLook;

	public GameObject stopSlendrina;

	public GameObject slendrinaEnd;

	public GameObject headBobAnimHolder;

	public float seeLenght;

	public GameObject gameController;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		RaycastHit hitInfo = default(RaycastHit);
		if (Physics.Raycast(transform.position, transform.forward, out hitInfo, seeLenght))
		{
			if (hitInfo.collider.gameObject.tag == "door")
			{
				doorE.SetActive(true);
				if (Input.GetKeyDown("e"))
				{
					hitInfo.collider.gameObject.GetComponent<Animation>().Play("OpenDoor");
					AudioSource.PlayClipAtPoint(Doorljud, transform.position);
					doorE.SetActive(false);
				}
			}
			else if (hitInfo.collider.gameObject.tag == "cellardoor")
			{
				doorE.SetActive(true);
				if (Input.GetKeyDown("e"))
				{
					hitInfo.collider.gameObject.GetComponent<Animation>().Play("OpenDoor");
					AudioSource.PlayClipAtPoint(CellarDoorljud, transform.position);
					doorE.SetActive(false);
				}
			}
			else if (hitInfo.collider.gameObject.tag == "doorlocked")
			{
				doorE.SetActive(true);
				if (Input.GetKeyDown("e"))
				{
					if (((CountKey)keyHolder.GetComponent(typeof(CountKey))).keys > 0)
					{
						((CountKey)keyHolder.GetComponent(typeof(CountKey))).countDownKey();
						AudioSource.PlayClipAtPoint(DoorUnLockedljud, transform.position);
						hitInfo.collider.gameObject.GetComponent<Animation>().Play("OpenDoor");
						doorE.SetActive(false);
						keyUsedText.SetActive(true);
						((textCrawl)keyUsedText.GetComponent(typeof(textCrawl))).travelDown = true;
					}
					else
					{
						doorLockedText.SetActive(true);
						AudioSource.PlayClipAtPoint(DoorLockedljud, transform.position);
						doorLockedText.SetActive(true);
						((textCrawl)doorLockedText.GetComponent(typeof(textCrawl))).travelDown = true;
					}
				}
			}
			else if (hitInfo.collider.gameObject.tag == "prisondoorlocked")
			{
				doorE.SetActive(true);
				if (Input.GetKeyDown("e"))
				{
					if (((CountKey)keyHolder.GetComponent(typeof(CountKey))).keys > 0)
					{
						((CountKey)keyHolder.GetComponent(typeof(CountKey))).countDownKey();
						AudioSource.PlayClipAtPoint(prisonDoorUnLockedljud, transform.position);
						hitInfo.collider.gameObject.GetComponent<Animation>().Play("OpenDoor");
						doorE.SetActive(false);
						keyUsedText.SetActive(true);
						((textCrawl)keyUsedText.GetComponent(typeof(textCrawl))).travelDown = true;
					}
					else
					{
						doorLockedText.SetActive(true);
						AudioSource.PlayClipAtPoint(DoorLockedljud, transform.position);
						doorLockedText.SetActive(true);
						((textCrawl)doorLockedText.GetComponent(typeof(textCrawl))).travelDown = true;
					}
				}
			}
			else if (hitInfo.collider.gameObject.tag == "steeldoorlocked")
			{
				doorE.SetActive(true);
				if (Input.GetKeyDown("e"))
				{
					if (((CountKey)keyHolder.GetComponent(typeof(CountKey))).keys > 0)
					{
						((CountKey)keyHolder.GetComponent(typeof(CountKey))).countDownKey();
						AudioSource.PlayClipAtPoint(steelDoorUnLockedljud, transform.position);
						hitInfo.collider.gameObject.GetComponent<Animation>().Play("OpenDoor");
						doorE.SetActive(false);
						keyUsedText.SetActive(true);
						((textCrawl)keyUsedText.GetComponent(typeof(textCrawl))).travelDown = true;
					}
					else
					{
						doorLockedText.SetActive(true);
						AudioSource.PlayClipAtPoint(DoorLockedljud, transform.position);
						doorLockedText.SetActive(true);
						((textCrawl)doorLockedText.GetComponent(typeof(textCrawl))).travelDown = true;
					}
				}
			}
			else if (hitInfo.collider.gameObject.tag == "findoorlocked")
			{
				doorE.SetActive(true);
				if (Input.GetKeyDown("e"))
				{
					if (((CountKey)keyHolder.GetComponent(typeof(CountKey))).keys > 0)
					{
						((CountKey)keyHolder.GetComponent(typeof(CountKey))).countDownKey();
						AudioSource.PlayClipAtPoint(finDoorUnLockedljud, transform.position);
						hitInfo.collider.gameObject.GetComponent<Animation>().Play("OpenDoor");
						doorE.SetActive(false);
						keyUsedText.SetActive(true);
						((textCrawl)keyUsedText.GetComponent(typeof(textCrawl))).travelDown = true;
					}
					else
					{
						doorLockedText.SetActive(true);
						AudioSource.PlayClipAtPoint(DoorLockedljud, transform.position);
						doorLockedText.SetActive(true);
						((textCrawl)doorLockedText.GetComponent(typeof(textCrawl))).travelDown = true;
					}
				}
			}
			else if (hitInfo.collider.gameObject.tag == "gardeH")
			{
				doorE.SetActive(true);
				if (Input.GetKeyDown("e"))
				{
					hitInfo.collider.gameObject.GetComponent<Animation>().Play("openH");
					AudioSource.PlayClipAtPoint(garderobLjud, transform.position);
					doorE.SetActive(false);
				}
			}
			else if (hitInfo.collider.gameObject.tag == "gardeV")
			{
				doorE.SetActive(true);
				if (Input.GetKeyDown("e"))
				{
					hitInfo.collider.gameObject.GetComponent<Animation>().Play("openV");
					AudioSource.PlayClipAtPoint(garderobLjud, transform.position);
					doorE.SetActive(false);
				}
			}
			else if (hitInfo.collider.gameObject.tag == "exitdoor")
			{
				doorE.SetActive(true);
				if (Input.GetKeyDown("e"))
				{
					if (((Counter)bookCounter.GetComponent(typeof(Counter))).counter == 8f)
					{
						AudioSource.PlayClipAtPoint(DoorUnLockedljud, transform.position);
						headBobAnimHolder.GetComponent<Animation>().CrossFade("playerIdle");
						((checkOngoing)gameController.GetComponent(typeof(checkOngoing))).onGoing = true;
						doorE.SetActive(false);
						playerScript.GetComponent<FPSInputController>().enabled = false;
						playerScript.GetComponent<MouseLook>().enabled = false;
						mouseLook.GetComponent<MouseLook>().enabled = false;
						((Footsteps)playerScript.GetComponent(typeof(Footsteps))).GetComponent<AudioSource>().Stop();
						hitInfo.collider.gameObject.tag = "Untagged";
						doorE.SetActive(false);
						StartCoroutine(end());
					}
					else
					{
						firstFind8BooksText.SetActive(true);
						((textCrawl)firstFind8BooksText.GetComponent(typeof(textCrawl))).travelDown = true;
					}
				}
			}
			else
			{
				doorE.SetActive(false);
			}
		}
		else
		{
			doorE.SetActive(false);
		}
	}

	public virtual IEnumerator end()
	{
		return new _0024end_0024397(this).GetEnumerator();
	}

	public virtual void Main()
	{
	}
}
