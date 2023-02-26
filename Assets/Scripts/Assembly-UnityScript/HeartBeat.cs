using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
[RequireComponent(typeof(AudioSource))]
public class HeartBeat : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024countDown_0024354 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal HeartBeat _0024self__0024355;

			public _0024(HeartBeat self_)
			{
				_0024self__0024355 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(3f)) ? 1 : 0);
					break;
				case 2:
					if (!(_0024self__0024355.pitch <= 1.05f))
					{
						_0024self__0024355.GetComponent<AudioSource>().pitch = _0024self__0024355.GetComponent<AudioSource>().pitch - 0.02f;
						_0024self__0024355.pitch -= 0.02f;
						_0024self__0024355.counderOn = true;
					}
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal HeartBeat _0024self__0024356;

		public _0024countDown_0024354(HeartBeat self_)
		{
			_0024self__0024356 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__0024356);
		}
	}

	public GameObject heartText;

	public float pitch;

	public bool counderOn;

	public HeartBeat()
	{
		pitch = 1f;
	}

	public virtual void Start()
	{
		GetComponent<AudioSource>().pitch = pitch;
	}

	public virtual void Update()
	{
		if (counderOn && !(pitch <= 1.05f))
		{
			StartCoroutine(countDown());
			counderOn = false;
		}
	}

	public virtual void seeGhost()
	{
		GetComponent<AudioSource>().pitch = GetComponent<AudioSource>().pitch + 0.3f;
		pitch += 0.3f;
		counderOn = true;
	}

	public virtual IEnumerator countDown()
	{
		return new _0024countDown_0024354(this).GetEnumerator();
	}

	public virtual void Main()
	{
	}
}
