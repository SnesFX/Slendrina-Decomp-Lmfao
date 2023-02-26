using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class DoorOpenClosed : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024doorTimer_0024300 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal DoorOpenClosed _0024self__0024301;

			public _0024(DoorOpenClosed self_)
			{
				_0024self__0024301 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 2:
					_0024self__0024301.GetComponent<BoxCollider>().enabled = true;
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal DoorOpenClosed _0024self__0024302;

		public _0024doorTimer_0024300(DoorOpenClosed self_)
		{
			_0024self__0024302 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__0024302);
		}
	}

	public bool doorOpen;

	public virtual void Update()
	{
		if (!doorOpen && GetComponent<Animation>().IsPlaying("OpenDoor"))
		{
			doorOpen = true;
			gameObject.tag = "Untagged";
		}
	}

	public virtual IEnumerator doorTimer()
	{
		return new _0024doorTimer_0024300(this).GetEnumerator();
	}

	public virtual void Main()
	{
	}
}
