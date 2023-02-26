using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class SoundTriggerScream : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024OnTriggerEnter_0024437 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Collider _0024other_0024438;

			internal SoundTriggerScream _0024self__0024439;

			public _0024(Collider other, SoundTriggerScream self_)
			{
				_0024other_0024438 = other;
				_0024self__0024439 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (_0024other_0024438.gameObject.tag == "Player" && !_0024self__0024439.soundOn)
					{
						((soundEffects)_0024self__0024439.soundHolder.GetComponent(typeof(soundEffects))).slendrinaScream();
						_0024self__0024439.soundOn = true;
						result = (Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
						break;
					}
					goto IL_0099;
				case 2:
					UnityEngine.Object.Destroy(_0024self__0024439.gameObject);
					goto IL_0099;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0099:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal Collider _0024other_0024440;

		internal SoundTriggerScream _0024self__0024441;

		public _0024OnTriggerEnter_0024437(Collider other, SoundTriggerScream self_)
		{
			_0024other_0024440 = other;
			_0024self__0024441 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024other_0024440, _0024self__0024441);
		}
	}

	public GameObject soundHolder;

	public bool soundOn;

	public virtual IEnumerator OnTriggerEnter(Collider other)
	{
		return new _0024OnTriggerEnter_0024437(other, this).GetEnumerator();
	}

	public virtual void Main()
	{
	}
}
