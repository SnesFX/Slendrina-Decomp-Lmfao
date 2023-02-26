using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class SlendrinaTriggerScript : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024OnTriggerEnter_0024427 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Collider _0024other_0024428;

			internal SlendrinaTriggerScript _0024self__0024429;

			public _0024(Collider other, SlendrinaTriggerScript self_)
			{
				_0024other_0024428 = other;
				_0024self__0024429 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (_0024other_0024428.gameObject.tag == "Player")
					{
						_0024self__0024429.animationHolder.SetActive(true);
						_0024self__0024429.animationHolder.GetComponent<Animation>().Play("SlendrinaHeadAnim2");
						result = (Yield(2, new WaitForSeconds(3f)) ? 1 : 0);
						break;
					}
					goto IL_0097;
				case 2:
					_0024self__0024429.animationHolder.SetActive(false);
					_0024self__0024429.trigger.SetActive(false);
					goto IL_0097;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0097:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal Collider _0024other_0024430;

		internal SlendrinaTriggerScript _0024self__0024431;

		public _0024OnTriggerEnter_0024427(Collider other, SlendrinaTriggerScript self_)
		{
			_0024other_0024430 = other;
			_0024self__0024431 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024other_0024430, _0024self__0024431);
		}
	}

	public GameObject animationHolder;

	public GameObject trigger;

	public virtual IEnumerator OnTriggerEnter(Collider other)
	{
		return new _0024OnTriggerEnter_0024427(other, this).GetEnumerator();
	}

	public virtual void Main()
	{
	}
}
