using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class SlendrinaStandScript : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024OnTriggerEnter_0024422 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Collider _0024other_0024423;

			internal SlendrinaStandScript _0024self__0024424;

			public _0024(Collider other, SlendrinaStandScript self_)
			{
				_0024other_0024423 = other;
				_0024self__0024424 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (_0024other_0024423.gameObject.tag == "Player")
					{
						((soundEffects)_0024self__0024424.soundHolder.GetComponent(typeof(soundEffects))).slendrinaStand();
						_0024self__0024424.animationHolder.GetComponent<Animation>().Play("turnaround");
						result = (Yield(2, new WaitForSeconds(0.3f)) ? 1 : 0);
						break;
					}
					goto IL_00d7;
				case 2:
					_0024self__0024424.face.SetActive(true);
					result = (Yield(3, new WaitForSeconds(0.1f)) ? 1 : 0);
					break;
				case 3:
					_0024self__0024424.face.SetActive(false);
					UnityEngine.Object.Destroy(_0024self__0024424.animationHolder);
					goto IL_00d7;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00d7:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal Collider _0024other_0024425;

		internal SlendrinaStandScript _0024self__0024426;

		public _0024OnTriggerEnter_0024422(Collider other, SlendrinaStandScript self_)
		{
			_0024other_0024425 = other;
			_0024self__0024426 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024other_0024425, _0024self__0024426);
		}
	}

	public GameObject animationHolder;

	public GameObject soundHolder;

	public GameObject face;

	public virtual void Start()
	{
	}

	public virtual IEnumerator OnTriggerEnter(Collider other)
	{
		return new _0024OnTriggerEnter_0024422(other, this).GetEnumerator();
	}

	public virtual void Main()
	{
	}
}
