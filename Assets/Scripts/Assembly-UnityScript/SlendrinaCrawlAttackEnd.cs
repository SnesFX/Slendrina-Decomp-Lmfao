using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class SlendrinaCrawlAttackEnd : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024blackScreenEnd_0024408 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal SlendrinaCrawlAttackEnd _0024self__0024409;

			public _0024(SlendrinaCrawlAttackEnd self_)
			{
				_0024self__0024409 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(3.8f)) ? 1 : 0);
					break;
				case 2:
					_0024self__0024409.blackScreen.SetActive(true);
					_0024self__0024409.slendrinaCrawlFace.SetActive(false);
					result = (Yield(3, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 3:
					_0024self__0024409.playerScript.GetComponent<FPSInputController>().enabled = true;
					_0024self__0024409.playerScript.GetComponent<MouseLook>().enabled = true;
					_0024self__0024409.mouseLook.GetComponent<MouseLook>().enabled = true;
					_0024self__0024409.animationHolder.GetComponent<Animation>().Play("playerIdle");
					_0024self__0024409.slendrina.SetActive(true);
					_0024self__0024409.blackScreen.SetActive(false);
					((checkOngoing)_0024self__0024409.gameController.GetComponent(typeof(checkOngoing))).onGoing = false;
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal SlendrinaCrawlAttackEnd _0024self__0024410;

		public _0024blackScreenEnd_0024408(SlendrinaCrawlAttackEnd self_)
		{
			_0024self__0024410 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__0024410);
		}
	}

	public GameObject slendrinaCrawlAttack;

	public GameObject blackScreen;

	public GameObject slendrinaCrawlFace;

	public GameObject slendrina;

	public GameObject playerScript;

	public GameObject mouseLook;

	public GameObject animationHolder;

	public AudioClip crawlSound;

	public GameObject gameController;

	public virtual void Start()
	{
	}

	public virtual void crawlEnd()
	{
		((checkOngoing)gameController.GetComponent(typeof(checkOngoing))).onGoing = true;
		slendrinaCrawlAttack.SetActive(true);
		AudioSource.PlayClipAtPoint(crawlSound, transform.position);
		playerScript.GetComponent<FPSInputController>().enabled = false;
		playerScript.GetComponent<MouseLook>().enabled = false;
		mouseLook.GetComponent<MouseLook>().enabled = false;
		((Footsteps)playerScript.GetComponent(typeof(Footsteps))).GetComponent<AudioSource>().Stop();
		animationHolder.GetComponent<Animation>().Stop("HeadBobAnimation");
		StartCoroutine(blackScreenEnd());
	}

	public virtual IEnumerator blackScreenEnd()
	{
		return new _0024blackScreenEnd_0024408(this).GetEnumerator();
	}

	public virtual void Main()
	{
	}
}
