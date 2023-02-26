using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class GirlSee : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024OnTriggerEnter_0024349 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Collider _0024other_0024350;

			internal GirlSee _0024self__0024351;

			public _0024(Collider other, GirlSee self_)
			{
				_0024other_0024350 = other;
				_0024self__0024351 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (_0024other_0024350.gameObject.tag == "girlhang")
					{
						AudioSource.PlayClipAtPoint(_0024self__0024351.girlLjud, _0024self__0024351.transform.position);
						_0024self__0024351.animationHolder.GetComponent<Animation>().Play("GirlSee");
						result = (Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
						break;
					}
					goto IL_0094;
				case 2:
					UnityEngine.Object.Destroy(_0024self__0024351.animationHolder);
					goto IL_0094;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0094:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal Collider _0024other_0024352;

		internal GirlSee _0024self__0024353;

		public _0024OnTriggerEnter_0024349(Collider other, GirlSee self_)
		{
			_0024other_0024352 = other;
			_0024self__0024353 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024other_0024352, _0024self__0024353);
		}
	}

	public AudioClip girlLjud;

	public GameObject animationHolder;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
	}

	public virtual IEnumerator OnTriggerEnter(Collider other)
	{
		return new _0024OnTriggerEnter_0024349(other, this).GetEnumerator();
	}

	public virtual void Main()
	{
	}
}
