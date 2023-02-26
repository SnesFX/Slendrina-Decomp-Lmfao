using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class FadeGuiTexture : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Start_0024311 : GenericGenerator<Coroutine>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<Coroutine>, IEnumerator
		{
			internal FadeGuiTexture _0024self__0024312;

			public _0024(FadeGuiTexture self_)
			{
				_0024self__0024312 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, _0024self__0024312.StartCoroutine(_0024self__0024312.Fade(1f, 0f, 4f))) ? 1 : 0);
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

		internal FadeGuiTexture _0024self__0024313;

		public _0024Start_0024311(FadeGuiTexture self_)
		{
			_0024self__0024313 = self_;
		}

		public override IEnumerator<Coroutine> GetEnumerator()
		{
			return new _0024(_0024self__0024313);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Fade_0024314 : GenericGenerator<object>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<object>, IEnumerator
		{
			internal float _0024speed_0024315;

			internal float _0024t_0024316;

			internal float _0024_0024122_0024317;

			internal Color _0024_0024123_0024318;

			internal float _0024startLevel_0024319;

			internal float _0024endLevel_0024320;

			internal float _0024duration_0024321;

			internal FadeGuiTexture _0024self__0024322;

			public _0024(float startLevel, float endLevel, float duration, FadeGuiTexture self_)
			{
				_0024startLevel_0024319 = startLevel;
				_0024endLevel_0024320 = endLevel;
				_0024duration_0024321 = duration;
				_0024self__0024322 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024speed_0024315 = 0.5f / _0024duration_0024321;
					_0024t_0024316 = 0f;
					goto IL_00c5;
				case 2:
					_0024t_0024316 += Time.deltaTime * _0024speed_0024315;
					goto IL_00c5;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00c5:
					if (_0024t_0024316 < 1f)
					{
						float num = (_0024_0024122_0024317 = Mathf.Lerp(_0024startLevel_0024319, _0024endLevel_0024320, _0024t_0024316));
						Color color = (_0024_0024123_0024318 = _0024self__0024322.myGUItexture.color);
						float num2 = (_0024_0024123_0024318.a = _0024_0024122_0024317);
						Color color3 = (_0024self__0024322.myGUItexture.color = _0024_0024123_0024318);
						result = (YieldDefault(2) ? 1 : 0);
						break;
					}
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal float _0024startLevel_0024323;

		internal float _0024endLevel_0024324;

		internal float _0024duration_0024325;

		internal FadeGuiTexture _0024self__0024326;

		public _0024Fade_0024314(float startLevel, float endLevel, float duration, FadeGuiTexture self_)
		{
			_0024startLevel_0024323 = startLevel;
			_0024endLevel_0024324 = endLevel;
			_0024duration_0024325 = duration;
			_0024self__0024326 = self_;
		}

		public override IEnumerator<object> GetEnumerator()
		{
			return new _0024(_0024startLevel_0024323, _0024endLevel_0024324, _0024duration_0024325, _0024self__0024326);
		}
	}

	public GUITexture myGUItexture;

	public virtual IEnumerator Start()
	{
		return new _0024Start_0024311(this).GetEnumerator();
	}

	public virtual IEnumerator Fade(float startLevel, float endLevel, float duration)
	{
		return new _0024Fade_0024314(startLevel, endLevel, duration, this).GetEnumerator();
	}

	public virtual void Main()
	{
	}
}
