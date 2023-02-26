using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class SlendrinaArm : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024OnTriggerEnter_0024403 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Collider _0024other_0024404;

			internal SlendrinaArm _0024self__0024405;

			public _0024(Collider other, SlendrinaArm self_)
			{
				_0024other_0024404 = other;
				_0024self__0024405 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (_0024other_0024404.gameObject.tag == "Player")
					{
						((soundEffects)_0024self__0024405.soundHolder.GetComponent(typeof(soundEffects))).tavla();
						_0024self__0024405.animationHolder.GetComponent<Animation>().Play();
						result = (Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
						break;
					}
					goto IL_0093;
				case 2:
					UnityEngine.Object.Destroy(_0024self__0024405.animationHolder);
					goto IL_0093;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0093:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal Collider _0024other_0024406;

		internal SlendrinaArm _0024self__0024407;

		public _0024OnTriggerEnter_0024403(Collider other, SlendrinaArm self_)
		{
			_0024other_0024406 = other;
			_0024self__0024407 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024other_0024406, _0024self__0024407);
		}
	}

	public GameObject animationHolder;

	public GameObject soundHolder;

	public virtual IEnumerator OnTriggerEnter(Collider other)
	{
		return new _0024OnTriggerEnter_0024403(other, this).GetEnumerator();
	}

	public virtual void Main()
	{
	}
}
