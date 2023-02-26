using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class PlayBackgroundSound : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024PlayBackSound_0024369 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayBackgroundSound _0024self__0024370;

			public _0024(PlayBackgroundSound self_)
			{
				_0024self__0024370 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__0024370.GetComponent<AudioSource>().clip = _0024self__0024370.backgroundSound;
					_0024self__0024370.GetComponent<AudioSource>().Play();
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal PlayBackgroundSound _0024self__0024371;

		public _0024PlayBackSound_0024369(PlayBackgroundSound self_)
		{
			_0024self__0024371 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__0024371);
		}
	}

	public AudioClip backgroundSound;

	public virtual IEnumerator PlayBackSound()
	{
		return new _0024PlayBackSound_0024369(this).GetEnumerator();
	}

	public virtual void Main()
	{
	}
}
