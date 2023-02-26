using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class TriggerCrawlSlendrina : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_0024442 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal TriggerCrawlSlendrina _0024self__0024443;

			public _0024(TriggerCrawlSlendrina self_)
			{
				_0024self__0024443 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__0024443.crawlAnimation.GetComponent<Animation>()["Crawling"].speed = 1.3f;
					result = (Yield(2, new WaitForSeconds(7f)) ? 1 : 0);
					break;
				case 2:
					_0024self__0024443.stopSlendrina.SetActive(true);
					UnityEngine.Object.Destroy(_0024self__0024443.gameObject);
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal TriggerCrawlSlendrina _0024self__0024444;

		public _0024Start_0024442(TriggerCrawlSlendrina self_)
		{
			_0024self__0024444 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__0024444);
		}
	}

	public GameObject stopSlendrina;

	public GameObject EndCrawl;

	public GameObject crawlAnimation;

	public virtual IEnumerator Start()
	{
		return new _0024Start_0024442(this).GetEnumerator();
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			((SlendrinaCrawlAttackEnd)EndCrawl.GetComponent(typeof(SlendrinaCrawlAttackEnd))).crawlEnd();
			UnityEngine.Object.Destroy(gameObject);
		}
	}

	public virtual void Main()
	{
	}
}
