using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class GardeDoorOpenSlendrina : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024headFly_0024303 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GardeDoorOpenSlendrina _0024self__0024304;

			public _0024(GardeDoorOpenSlendrina self_)
			{
				_0024self__0024304 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 2:
					_0024self__0024304.slendrina.SetActive(true);
					((soundEffects)_0024self__0024304.soundHolder.GetComponent(typeof(soundEffects))).HeadGarde();
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal GardeDoorOpenSlendrina _0024self__0024305;

		public _0024headFly_0024303(GardeDoorOpenSlendrina self_)
		{
			_0024self__0024305 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__0024305);
		}
	}

	public bool doorOpen;

	public GameObject slendrina;

	public GameObject soundHolder;

	public virtual void Update()
	{
		if (!doorOpen)
		{
			if (GetComponent<Animation>().IsPlaying("openH"))
			{
				doorOpen = true;
				gameObject.tag = "Untagged";
			}
			else if (GetComponent<Animation>().IsPlaying("openV"))
			{
				StartCoroutine(headFly());
				doorOpen = true;
				gameObject.tag = "Untagged";
			}
		}
	}

	public virtual IEnumerator headFly()
	{
		return new _0024headFly_0024303(this).GetEnumerator();
	}

	public virtual void Main()
	{
	}
}
