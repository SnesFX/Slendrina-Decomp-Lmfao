using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class ClickOK : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024mainMenu_0024288 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(4f)) ? 1 : 0);
					break;
				case 2:
					Application.LoadLevel("MainMenu");
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			//yield-return decompiler failed: Method not found
			return new _0024();
		}
	}

	public GameObject audioStop;

	public GameObject fadeOut;

	public AudioClip KlickLjud;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		int i = 0;
		Touch[] touches = Input.touches;
		for (int length = touches.Length; i < length; i++)
		{
			if (touches[i].phase == TouchPhase.Ended && GetComponent<GUITexture>().HitTest(touches[i].position))
			{
				AudioSource.PlayClipAtPoint(KlickLjud, transform.position);
				((StopAllSound)audioStop.GetComponent(typeof(StopAllSound))).stopSounds();
				fadeOut.SetActive(true);
				StartCoroutine(mainMenu());
			}
		}
	}

	public virtual IEnumerator mainMenu()
	{
		return new _0024mainMenu_0024288().GetEnumerator();
	}

	public virtual void Main()
	{
	}
}
