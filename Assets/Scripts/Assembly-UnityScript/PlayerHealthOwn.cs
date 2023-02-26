using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class PlayerHealthOwn : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024blackScreen_0024400 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerHealthOwn _0024self__0024401;

			public _0024(PlayerHealthOwn self_)
			{
				_0024self__0024401 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(1.8f)) ? 1 : 0);
					break;
				case 2:
					_0024self__0024401.fadeOut.SetActive(true);
					_0024self__0024401.gameOver.SetActive(true);
					result = (Yield(3, new WaitForSeconds(7f)) ? 1 : 0);
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

		internal PlayerHealthOwn _0024self__0024402;

		public _0024blackScreen_0024400(PlayerHealthOwn self_)
		{
			_0024self__0024402 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__0024402);
		}
	}

	public Renderer staticRenderer;

	public float health;

	public float healthDecayRate;

	public GameObject gameOver;

	public GameObject audioStop;

	public GameObject fadeOut;

	public GameObject stopMovement;

	public GameObject touchArea;

	public Transform target;

	public float speed;

	public GameObject screenSoundHolder;

	public GameObject stopSlender;

	public GameObject slendrinaAnim;

	public GameObject slendrinafaceAnim;

	public GameObject slendrinaface;

	public GameObject optionButton;

	public bool seeSlendrina;

	public bool seeSlendrinaOnce;

	private float healthDecayRateModifier;

	private float decayModifier;

	private float startingHealth;

	public PlayerHealthOwn()
	{
		health = 100f;
		speed = 20f;
		healthDecayRateModifier = 0.2f;
	}

	public virtual void Start()
	{
		startingHealth = health;
		decayModifier = startingHealth / healthDecayRate;
		GameObject gameObject = GameObject.Find("ScreenEffect");
		if ((bool)gameObject)
		{
			staticRenderer = gameObject.GetComponent<Renderer>();
		}
		float a = 0f;
		Color color = staticRenderer.material.color;
		float num = (color.a = a);
		Color color3 = (staticRenderer.material.color = color);
	}

	public virtual void Update()
	{
		if (!seeSlendrina)
		{
			int num = 0;
			Vector3 localEulerAngles = transform.localEulerAngles;
			float num2 = (localEulerAngles.z = num);
			Vector3 vector2 = (transform.localEulerAngles = localEulerAngles);
			int num3 = 0;
			Vector3 localEulerAngles2 = transform.localEulerAngles;
			float num4 = (localEulerAngles2.x = num3);
			Vector3 vector4 = (transform.localEulerAngles = localEulerAngles2);
		}
	}

	public virtual void DecreaseHealth()
	{
		slendrinaAnim.GetComponent<Animation>().Play("attack");
		slendrinaAnim.GetComponent<Animation>()["attack"].speed = 0.5f;
		health -= healthDecayRate * Time.deltaTime;
		((PlayMusic)screenSoundHolder.GetComponent(typeof(PlayMusic))).fadeUp();
		float num = 1f - health / startingHealth;
		float a = num;
		Color color = staticRenderer.material.color;
		float num2 = (color.a = a);
		Color color3 = (staticRenderer.material.color = color);
		if (!(health > 0f))
		{
			health = 0f;
			stopSlender.SetActive(false);
			slendrinaface.SetActive(true);
			slendrinafaceAnim.GetComponent<Animation>()["faceattack"].wrapMode = WrapMode.Once;
			slendrinafaceAnim.GetComponent<Animation>().Play("faceattack");
			slendrinafaceAnim.GetComponent<Animation>()["faceattack"].speed = 0.5f;
			((FPSControllerNEW)stopMovement.GetComponent(typeof(FPSControllerNEW))).enabled = false;
			touchArea.SetActive(false);
			optionButton.SetActive(false);
			StartCoroutine(blackScreen());
		}
	}

	public virtual void IncreaseHealth()
	{
		seeSlendrina = false;
		health += healthDecayRate * Time.deltaTime;
		((PlayMusic)screenSoundHolder.GetComponent(typeof(PlayMusic))).fadeDown();
		float num = 1f - health / startingHealth;
		float a = num;
		Color color = staticRenderer.material.color;
		float num2 = (color.a = a);
		Color color3 = (staticRenderer.material.color = color);
		if (!(health < startingHealth))
		{
			health = startingHealth;
		}
	}

	public virtual void faceGhost()
	{
		Quaternion b = Quaternion.LookRotation(target.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2, Screen.height / 2, Camera.main.nearClipPlane)));
		transform.rotation = Quaternion.Slerp(transform.rotation, b, Time.deltaTime * speed);
		Debug.Log("Ser Slendrina");
		seeSlendrina = true;
	}

	public virtual IEnumerator blackScreen()
	{
		return new _0024blackScreen_0024400(this).GetEnumerator();
	}

	public virtual void Main()
	{
	}
}
