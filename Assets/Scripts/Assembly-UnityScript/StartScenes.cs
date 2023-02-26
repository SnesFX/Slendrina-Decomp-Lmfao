using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class StartScenes : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024play_0024394 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal StartScenes _0024self__0024395;

			public _0024(StartScenes self_)
			{
				_0024self__0024395 = self_;
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
					if (_0024self__0024395.level1)
					{
						Application.LoadLevel("Level1");
					}
					if (_0024self__0024395.level2)
					{
						Application.LoadLevel("Level2");
					}
					if (_0024self__0024395.level3)
					{
						Application.LoadLevel("Level3");
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

		internal StartScenes _0024self__0024396;

		public _0024play_0024394(StartScenes self_)
		{
			_0024self__0024396 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__0024396);
		}
	}

	public bool ready;

	public bool level1;

	public bool level2;

	public bool level3;

	public virtual void Update()
	{
		if (ready)
		{
			ready = false;
			StartCoroutine(play());
		}
	}

	public virtual IEnumerator play()
	{
		return new _0024play_0024394(this).GetEnumerator();
	}

	public virtual void Main()
	{
	}
}
