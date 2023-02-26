using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class FaceScareTrigger : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024OnTriggerEnter_0024306 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Collider _0024other_0024307;

			internal FaceScareTrigger _0024self__0024308;

			public _0024(Collider other, FaceScareTrigger self_)
			{
				_0024other_0024307 = other;
				_0024self__0024308 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (_0024other_0024307.gameObject.tag == "Player")
					{
						_0024self__0024308.slendrinaFace.SetActive(true);
						result = (Yield(2, new WaitForSeconds(0.08f)) ? 1 : 0);
						break;
					}
					goto IL_00a2;
				case 2:
					_0024self__0024308.slendrinaFace.SetActive(false);
					((soundEffects)_0024self__0024308.soundHolder.GetComponent(typeof(soundEffects))).slendrinaHeadDoor();
					UnityEngine.Object.Destroy(_0024self__0024308.gameObject);
					goto IL_00a2;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00a2:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal Collider _0024other_0024309;

		internal FaceScareTrigger _0024self__0024310;

		public _0024OnTriggerEnter_0024306(Collider other, FaceScareTrigger self_)
		{
			_0024other_0024309 = other;
			_0024self__0024310 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024other_0024309, _0024self__0024310);
		}
	}

	public GameObject slendrinaFace;

	public GameObject soundHolder;

	public virtual void Start()
	{
	}

	public virtual IEnumerator OnTriggerEnter(Collider other)
	{
		return new _0024OnTriggerEnter_0024306(other, this).GetEnumerator();
	}

	public virtual void Main()
	{
	}
}
