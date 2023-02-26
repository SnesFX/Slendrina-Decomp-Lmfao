using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class DatorTriggerScript : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024OnTriggerEnter_0024289 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Collider _0024other_0024290;

			internal DatorTriggerScript _0024self__0024291;

			public _0024(Collider other, DatorTriggerScript self_)
			{
				_0024other_0024290 = other;
				_0024self__0024291 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (_0024other_0024290.gameObject.tag == "Player")
					{
						((soundEffects)_0024self__0024291.soundHolder.GetComponent(typeof(soundEffects))).screenFace();
						_0024self__0024291.GetComponent<Renderer>().material.mainTexture = _0024self__0024291.screen;
						result = (Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
						break;
					}
					goto IL_0131;
				case 2:
					_0024self__0024291.GetComponent<Renderer>().material.mainTexture = _0024self__0024291.black;
					result = (Yield(3, new WaitForSeconds(0.05f)) ? 1 : 0);
					break;
				case 3:
					_0024self__0024291.GetComponent<Renderer>().material.mainTexture = _0024self__0024291.screen;
					result = (Yield(4, new WaitForSeconds(0.05f)) ? 1 : 0);
					break;
				case 4:
					_0024self__0024291.GetComponent<Renderer>().material.mainTexture = _0024self__0024291.black;
					UnityEngine.Object.Destroy(_0024self__0024291.trigger);
					goto IL_0131;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0131:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal Collider _0024other_0024292;

		internal DatorTriggerScript _0024self__0024293;

		public _0024OnTriggerEnter_0024289(Collider other, DatorTriggerScript self_)
		{
			_0024other_0024292 = other;
			_0024self__0024293 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024other_0024292, _0024self__0024293);
		}
	}

	public GameObject soundHolder;

	public Texture2D screen;

	public Texture2D black;

	public GameObject trigger;

	public virtual void Start()
	{
	}

	public virtual IEnumerator OnTriggerEnter(Collider other)
	{
		return new _0024OnTriggerEnter_0024289(other, this).GetEnumerator();
	}

	public virtual void Main()
	{
	}
}
