using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class WhatLevelIsVald : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024play_0024445 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal WhatLevelIsVald _0024self__0024446;

			public _0024(WhatLevelIsVald self_)
			{
				_0024self__0024446 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (_0024self__0024446.warehouse)
					{
						result = (Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
						break;
					}
					if (_0024self__0024446.hotel)
					{
						result = (Yield(3, new WaitForSeconds(2f)) ? 1 : 0);
						break;
					}
					if (_0024self__0024446.yard)
					{
						result = (Yield(4, new WaitForSeconds(2f)) ? 1 : 0);
						break;
					}
					if (_0024self__0024446.swamp)
					{
						result = (Yield(5, new WaitForSeconds(2f)) ? 1 : 0);
						break;
					}
					goto IL_00ea;
				case 2:
					Application.LoadLevel("Warehouse");
					goto IL_00ea;
				case 3:
					Application.LoadLevel("Hotel");
					goto IL_00ea;
				case 4:
					Application.LoadLevel("Farm");
					goto IL_00ea;
				case 5:
					Application.LoadLevel("Forest");
					goto IL_00ea;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00ea:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal WhatLevelIsVald _0024self__0024447;

		public _0024play_0024445(WhatLevelIsVald self_)
		{
			_0024self__0024447 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__0024447);
		}
	}

	public bool warehouse;

	public bool hotel;

	public bool yard;

	public bool swamp;

	public virtual IEnumerator play()
	{
		return new _0024play_0024445(this).GetEnumerator();
	}

	public virtual void Main()
	{
	}
}
