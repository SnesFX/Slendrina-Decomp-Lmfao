using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
[RequireComponent(typeof(Light))]
public class FlashlightBasicFlicker : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024MildFlicker_0024461 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal FlashlightBasicFlicker _0024self__0024462;

			public _0024(FlashlightBasicFlicker self_)
			{
				_0024self__0024462 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__0024462.currentIntensity = 0f;
					_0024self__0024462.GetComponent<Light>().intensity = _0024self__0024462.currentIntensity;
					result = (Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__0024462.currentIntensity = _0024self__0024462.startIntensity;
					_0024self__0024462.GetComponent<Light>().intensity = _0024self__0024462.currentIntensity;
					result = (Yield(3, new WaitForSeconds(0.1f)) ? 1 : 0);
					break;
				case 3:
					_0024self__0024462.currentIntensity = 0f;
					_0024self__0024462.GetComponent<Light>().intensity = _0024self__0024462.currentIntensity;
					result = (Yield(4, new WaitForSeconds(0.1f)) ? 1 : 0);
					break;
				case 4:
					_0024self__0024462.currentIntensity = _0024self__0024462.startIntensity;
					_0024self__0024462.GetComponent<Light>().intensity = _0024self__0024462.currentIntensity;
					result = (Yield(5, new WaitForSeconds(0.1f)) ? 1 : 0);
					break;
				case 5:
					_0024self__0024462.currentIntensity = 0f;
					_0024self__0024462.GetComponent<Light>().intensity = _0024self__0024462.currentIntensity;
					result = (Yield(6, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 6:
					_0024self__0024462.currentIntensity = _0024self__0024462.startIntensity;
					_0024self__0024462.GetComponent<Light>().intensity = _0024self__0024462.currentIntensity;
					result = (Yield(7, new WaitForSeconds(0.1f)) ? 1 : 0);
					break;
				case 7:
					_0024self__0024462.currentIntensity = 0f;
					_0024self__0024462.GetComponent<Light>().intensity = _0024self__0024462.currentIntensity;
					result = (Yield(8, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 8:
					_0024self__0024462.currentIntensity = _0024self__0024462.startIntensity;
					_0024self__0024462.GetComponent<Light>().intensity = _0024self__0024462.currentIntensity;
					result = (Yield(9, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 9:
					_0024self__0024462.currentIntensity = 0f;
					_0024self__0024462.GetComponent<Light>().intensity = _0024self__0024462.currentIntensity;
					result = (Yield(10, new WaitForSeconds(0.1f)) ? 1 : 0);
					break;
				case 10:
					_0024self__0024462.currentIntensity = _0024self__0024462.startIntensity;
					_0024self__0024462.GetComponent<Light>().intensity = _0024self__0024462.currentIntensity;
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal FlashlightBasicFlicker _0024self__0024463;

		public _0024MildFlicker_0024461(FlashlightBasicFlicker self_)
		{
			_0024self__0024463 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__0024463);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024FadeFlicker_0024464 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal bool _0024isFading_0024465;

			internal FlashlightBasicFlicker _0024self__0024466;

			public _0024(FlashlightBasicFlicker self_)
			{
				_0024self__0024466 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024isFading_0024465 = true;
					goto case 2;
				case 2:
					if (_0024isFading_0024465)
					{
						_0024self__0024466.currentIntensity -= 0.02f;
						if (!(_0024self__0024466.currentIntensity >= 0f))
						{
							_0024self__0024466.currentIntensity = 0f;
							_0024isFading_0024465 = false;
						}
						_0024self__0024466.GetComponent<Light>().intensity = _0024self__0024466.currentIntensity;
						result = (YieldDefault(2) ? 1 : 0);
					}
					else
					{
						_0024self__0024466.currentIntensity = _0024self__0024466.startIntensity;
						_0024self__0024466.GetComponent<Light>().intensity = _0024self__0024466.currentIntensity;
						result = (Yield(3, new WaitForSeconds(0.1f)) ? 1 : 0);
					}
					break;
				case 3:
					_0024self__0024466.currentIntensity = 0f;
					_0024self__0024466.GetComponent<Light>().intensity = _0024self__0024466.currentIntensity;
					result = (Yield(4, new WaitForSeconds(0.1f)) ? 1 : 0);
					break;
				case 4:
					_0024self__0024466.currentIntensity = _0024self__0024466.startIntensity;
					_0024self__0024466.GetComponent<Light>().intensity = _0024self__0024466.currentIntensity;
					result = (Yield(5, new WaitForSeconds(0.1f)) ? 1 : 0);
					break;
				case 5:
					_0024self__0024466.currentIntensity = 0f;
					_0024self__0024466.GetComponent<Light>().intensity = _0024self__0024466.currentIntensity;
					result = (Yield(6, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 6:
					_0024self__0024466.currentIntensity = _0024self__0024466.startIntensity;
					_0024self__0024466.GetComponent<Light>().intensity = _0024self__0024466.currentIntensity;
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal FlashlightBasicFlicker _0024self__0024467;

		public _0024FadeFlicker_0024464(FlashlightBasicFlicker self_)
		{
			_0024self__0024467 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__0024467);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024RandomIntensity_0024468 : GenericGenerator<object>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<object>, IEnumerator
		{
			internal int _0024rndCount_0024469;

			internal FlashlightBasicFlicker _0024self__0024470;

			public _0024(FlashlightBasicFlicker self_)
			{
				_0024self__0024470 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024rndCount_0024469 = 0;
					goto case 2;
				case 2:
					if (_0024rndCount_0024469 < 45)
					{
						_0024self__0024470.currentIntensity = UnityEngine.Random.Range(0.1f, _0024self__0024470.startIntensity);
						_0024self__0024470.GetComponent<Light>().intensity = _0024self__0024470.currentIntensity;
						_0024rndCount_0024469++;
						result = (YieldDefault(2) ? 1 : 0);
						break;
					}
					_0024self__0024470.currentIntensity = _0024self__0024470.startIntensity;
					_0024self__0024470.GetComponent<Light>().intensity = _0024self__0024470.currentIntensity;
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal FlashlightBasicFlicker _0024self__0024471;

		public _0024RandomIntensity_0024468(FlashlightBasicFlicker self_)
		{
			_0024self__0024471 = self_;
		}

		public override IEnumerator<object> GetEnumerator()
		{
			return new _0024(_0024self__0024471);
		}
	}

	private float timer;

	private float timerMax;

	public float delayTimeBeforeEffect;

	public float delayTimeOffset;

	private float startIntensity;

	private float currentIntensity;

	public FlashlightBasicFlicker()
	{
		timerMax = 60f;
		delayTimeBeforeEffect = 60f;
		delayTimeOffset = 20f;
	}

	public virtual void Start()
	{
		startIntensity = GetComponent<Light>().intensity;
		currentIntensity = startIntensity;
		GenerateMaxTime();
	}

	public virtual void Update()
	{
		timer += Time.deltaTime;
		if (!(timer <= timerMax))
		{
			timer = 0f;
			GenerateMaxTime();
			switch (UnityEngine.Random.Range(0, 3))
			{
			case 0:
				StartCoroutine(MildFlicker());
				break;
			case 1:
				StartCoroutine(FadeFlicker());
				break;
			case 2:
				StartCoroutine(RandomIntensity());
				break;
			}
		}
	}

	public virtual void GenerateMaxTime()
	{
		timerMax = delayTimeBeforeEffect + UnityEngine.Random.Range(0f - delayTimeOffset, delayTimeOffset);
	}

	public virtual IEnumerator MildFlicker()
	{
		return new _0024MildFlicker_0024461(this).GetEnumerator();
	}

	public virtual IEnumerator FadeFlicker()
	{
		return new _0024FadeFlicker_0024464(this).GetEnumerator();
	}

	public virtual IEnumerator RandomIntensity()
	{
		return new _0024RandomIntensity_0024468(this).GetEnumerator();
	}

	public virtual void Main()
	{
	}
}
