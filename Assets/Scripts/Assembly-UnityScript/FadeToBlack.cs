using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class FadeToBlack : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_0024327 : GenericGenerator<Coroutine>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<Coroutine>, IEnumerator
		{
			internal FadeToBlack _0024self__0024328;

			public _0024(FadeToBlack self_)
			{
				_0024self__0024328 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, _0024self__0024328.StartCoroutine(_0024self__0024328.Fade(0f, 1f, 4f))) ? 1 : 0);
					break;
				case 2:
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal FadeToBlack _0024self__0024329;

		public _0024Start_0024327(FadeToBlack self_)
		{
			_0024self__0024329 = self_;
		}

		public override IEnumerator<Coroutine> GetEnumerator()
		{
			return new _0024(_0024self__0024329);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Fade_0024330 : GenericGenerator<object>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<object>, IEnumerator
		{
			internal float _0024speed_0024331;

			internal float _0024t_0024332;

			internal float _0024_0024124_0024333;

			internal Color _0024_0024125_0024334;

			internal float _0024startLevel_0024335;

			internal float _0024endLevel_0024336;

			internal float _0024duration_0024337;

			internal FadeToBlack _0024self__0024338;

			public _0024(float startLevel, float endLevel, float duration, FadeToBlack self_)
			{
				_0024startLevel_0024335 = startLevel;
				_0024endLevel_0024336 = endLevel;
				_0024duration_0024337 = duration;
				_0024self__0024338 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024speed_0024331 = 0.5f / _0024duration_0024337;
					_0024t_0024332 = 0f;
					goto IL_00c5;
				case 2:
					_0024t_0024332 += Time.deltaTime * _0024speed_0024331;
					goto IL_00c5;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00c5:
					if (_0024t_0024332 < 1f)
					{
						float num = (_0024_0024124_0024333 = Mathf.Lerp(_0024startLevel_0024335, _0024endLevel_0024336, _0024t_0024332));
						Color color = (_0024_0024125_0024334 = _0024self__0024338.myGUItexture.color);
						float num2 = (_0024_0024125_0024334.a = _0024_0024124_0024333);
						Color color3 = (_0024self__0024338.myGUItexture.color = _0024_0024125_0024334);
						result = (YieldDefault(2) ? 1 : 0);
						break;
					}
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal float _0024startLevel_0024339;

		internal float _0024endLevel_0024340;

		internal float _0024duration_0024341;

		internal FadeToBlack _0024self__0024342;

		public _0024Fade_0024330(float startLevel, float endLevel, float duration, FadeToBlack self_)
		{
			_0024startLevel_0024339 = startLevel;
			_0024endLevel_0024340 = endLevel;
			_0024duration_0024341 = duration;
			_0024self__0024342 = self_;
		}

		public override IEnumerator<object> GetEnumerator()
		{
			return new _0024(_0024startLevel_0024339, _0024endLevel_0024340, _0024duration_0024341, _0024self__0024342);
		}
	}

	public GUITexture myGUItexture;

	public virtual IEnumerator Start()
	{
		return new _0024Start_0024327(this).GetEnumerator();
	}

	public virtual IEnumerator Fade(float startLevel, float endLevel, float duration)
	{
		return new _0024Fade_0024330(startLevel, endLevel, duration, this).GetEnumerator();
	}

	public virtual void Main()
	{
	}
}
