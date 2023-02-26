using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class SlendrinaEndScript : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_0024416 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal SlendrinaEndScript _0024self__0024417;

			public _0024(SlendrinaEndScript self_)
			{
				_0024self__0024417 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					AudioSource.PlayClipAtPoint(_0024self__0024417.endLjud, _0024self__0024417.transform.position);
					result = (Yield(2, new WaitForSeconds(4f)) ? 1 : 0);
					break;
				case 2:
					_0024self__0024417.youMadeItText.SetActive(true);
					_0024self__0024417.StartCoroutine(_0024self__0024417.end());
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal SlendrinaEndScript _0024self__0024418;

		public _0024Start_0024416(SlendrinaEndScript self_)
		{
			_0024self__0024418 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__0024418);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024end_0024419 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal SlendrinaEndScript _0024self__0024420;

			public _0024(SlendrinaEndScript self_)
			{
				_0024self__0024420 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(4f)) ? 1 : 0);
					break;
				case 2:
					_0024self__0024420.fadeBlack.SetActive(true);
					result = (Yield(3, new WaitForSeconds(6f)) ? 1 : 0);
					break;
				case 3:
					Application.LoadLevel("Menu");
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal SlendrinaEndScript _0024self__0024421;

		public _0024end_0024419(SlendrinaEndScript self_)
		{
			_0024self__0024421 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__0024421);
		}
	}

	public AudioClip endLjud;

	public GameObject youMadeItText;

	public GameObject fadeBlack;

	public GameObject difficultyHolder;

	public virtual IEnumerator Start()
	{
		return new _0024Start_0024416(this).GetEnumerator();
	}

	public virtual IEnumerator end()
	{
		return new _0024end_0024419(this).GetEnumerator();
	}

	public virtual void Main()
	{
	}
}
