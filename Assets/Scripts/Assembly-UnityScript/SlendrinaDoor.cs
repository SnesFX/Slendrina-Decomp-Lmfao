using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class SlendrinaDoor : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024OnTriggerEnter_0024411 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Collider _0024other_0024412;

			internal SlendrinaDoor _0024self__0024413;

			public _0024(Collider other, SlendrinaDoor self_)
			{
				_0024other_0024412 = other;
				_0024self__0024413 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (_0024other_0024412.gameObject.tag == "Player")
					{
						((soundEffects)_0024self__0024413.soundHolder.GetComponent(typeof(soundEffects))).slendrinaHeadDoor();
						_0024self__0024413.animationHolder.GetComponent<Animation>().Play();
						UnityEngine.Object.Destroy(_0024self__0024413.trigger);
						result = (Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
						break;
					}
					goto IL_00a3;
				case 2:
					UnityEngine.Object.Destroy(_0024self__0024413.animationHolder);
					goto IL_00a3;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00a3:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal Collider _0024other_0024414;

		internal SlendrinaDoor _0024self__0024415;

		public _0024OnTriggerEnter_0024411(Collider other, SlendrinaDoor self_)
		{
			_0024other_0024414 = other;
			_0024self__0024415 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024other_0024414, _0024self__0024415);
		}
	}

	public GameObject animationHolder;

	public GameObject soundHolder;

	public GameObject trigger;

	public virtual IEnumerator OnTriggerEnter(Collider other)
	{
		return new _0024OnTriggerEnter_0024411(other, this).GetEnumerator();
	}

	public virtual void Main()
	{
	}
}
