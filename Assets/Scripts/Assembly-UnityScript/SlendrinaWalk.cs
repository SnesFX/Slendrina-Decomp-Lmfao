using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class SlendrinaWalk : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024OnTriggerEnter_0024432 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Collider _0024other_0024433;

			internal SlendrinaWalk _0024self__0024434;

			public _0024(Collider other, SlendrinaWalk self_)
			{
				_0024other_0024433 = other;
				_0024self__0024434 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (_0024other_0024433.gameObject.tag == "Player")
					{
						((soundEffects)_0024self__0024434.soundHolder.GetComponent(typeof(soundEffects))).slendrinaWalk();
						_0024self__0024434.animationHolder.GetComponent<Animation>().Play("SlendrinaWalk");
						result = (Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
						break;
					}
					goto IL_0098;
				case 2:
					UnityEngine.Object.Destroy(_0024self__0024434.animationHolder);
					goto IL_0098;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0098:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal Collider _0024other_0024435;

		internal SlendrinaWalk _0024self__0024436;

		public _0024OnTriggerEnter_0024432(Collider other, SlendrinaWalk self_)
		{
			_0024other_0024435 = other;
			_0024self__0024436 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024other_0024435, _0024self__0024436);
		}
	}

	public GameObject animationHolder;

	public GameObject soundHolder;

	public virtual IEnumerator OnTriggerEnter(Collider other)
	{
		return new _0024OnTriggerEnter_0024432(other, this).GetEnumerator();
	}

	public virtual void Main()
	{
	}
}
