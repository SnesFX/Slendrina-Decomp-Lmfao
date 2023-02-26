using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class PlayerHealth : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024HealthIncreaseBite_0024372 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerHealth _0024self__0024373;

			public _0024(PlayerHealth self_)
			{
				_0024self__0024373 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__0024373.playerBleed = false;
					_0024self__0024373.playerRiven = false;
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerHealth _0024self__0024374;

		public _0024HealthIncreaseBite_0024372(PlayerHealth self_)
		{
			_0024self__0024374 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__0024374);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024HealthIncreaseRiven_0024375 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerHealth _0024self__0024376;

			public _0024(PlayerHealth self_)
			{
				_0024self__0024376 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__0024376.playerBleed = false;
					_0024self__0024376.playerRiven = false;
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerHealth _0024self__0024377;

		public _0024HealthIncreaseRiven_0024375(PlayerHealth self_)
		{
			_0024self__0024377 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__0024377);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024playerDead_0024378 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerHealth _0024self__0024379;

			public _0024(PlayerHealth self_)
			{
				_0024self__0024379 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__0024379.playerScript.GetComponent<FPSInputController>().enabled = false;
					_0024self__0024379.playerScript.GetComponent<MouseLook>().enabled = false;
					_0024self__0024379.mouseLook.GetComponent<MouseLook>().enabled = false;
					((Footsteps)_0024self__0024379.playerScript.GetComponent(typeof(Footsteps))).GetComponent<AudioSource>().Stop();
					_0024self__0024379.slendrinaInFace.SetActive(true);
					_0024self__0024379.slendrina.SetActive(false);
					result = (Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 2:
					_0024self__0024379.blackScreen.SetActive(true);
					result = (Yield(3, new WaitForSeconds(3f)) ? 1 : 0);
					break;
				case 3:
					_0024self__0024379.gameOverText.SetActive(true);
					result = (Yield(4, new WaitForSeconds(7f)) ? 1 : 0);
					break;
				case 4:
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

		internal PlayerHealth _0024self__0024380;

		public _0024playerDead_0024378(PlayerHealth self_)
		{
			_0024self__0024380 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__0024380);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024seeSlendrina_0024381 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerHealth _0024self__0024382;

			public _0024(PlayerHealth self_)
			{
				_0024self__0024382 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 2:
					_0024self__0024382.seeSlendrinaFreeze = true;
					result = (Yield(3, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 3:
					_0024self__0024382.seeSlendrinaFreeze = false;
					result = (Yield(4, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 4:
					_0024self__0024382.seeSlendrinaFreeze = true;
					result = (Yield(5, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 5:
					_0024self__0024382.seeSlendrinaFreeze = false;
					result = (Yield(6, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 6:
					_0024self__0024382.seeSlendrinaFreeze = true;
					result = (Yield(7, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 7:
					_0024self__0024382.seeSlendrinaFreeze = false;
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal PlayerHealth _0024self__0024383;

		public _0024seeSlendrina_0024381(PlayerHealth self_)
		{
			_0024self__0024383 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__0024383);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Fade_0024384 : GenericGenerator<object>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<object>, IEnumerator
		{
			internal float _0024t_0024385;

			internal float _0024_0024156_0024386;

			internal Color _0024_0024157_0024387;

			internal float _0024startLevel_0024388;

			internal float _0024endLevel_0024389;

			internal PlayerHealth _0024self__0024390;

			public _0024(float startLevel, float endLevel, PlayerHealth self_)
			{
				_0024startLevel_0024388 = startLevel;
				_0024endLevel_0024389 = endLevel;
				_0024self__0024390 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024t_0024385 = 0f;
					goto IL_00b8;
				case 2:
					_0024t_0024385 += Time.deltaTime * _0024self__0024390.fadeBlackSpeed;
					goto IL_00b8;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00b8:
					if (_0024t_0024385 < 1f)
					{
						float num = (_0024_0024156_0024386 = Mathf.Lerp(_0024startLevel_0024388, _0024endLevel_0024389, _0024t_0024385));
						Color color = (_0024_0024157_0024387 = _0024self__0024390.blackScreenNewChance.color);
						float num2 = (_0024_0024157_0024387.a = _0024_0024156_0024386);
						Color color3 = (_0024self__0024390.blackScreenNewChance.color = _0024_0024157_0024387);
						result = (YieldDefault(2) ? 1 : 0);
						break;
					}
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal float _0024startLevel_0024391;

		internal float _0024endLevel_0024392;

		internal PlayerHealth _0024self__0024393;

		public _0024Fade_0024384(float startLevel, float endLevel, PlayerHealth self_)
		{
			_0024startLevel_0024391 = startLevel;
			_0024endLevel_0024392 = endLevel;
			_0024self__0024393 = self_;
		}

		public override IEnumerator<object> GetEnumerator()
		{
			return new _0024(_0024startLevel_0024391, _0024endLevel_0024392, _0024self__0024393);
		}
	}

	public GameObject target;

	public GameObject slendrina;

	public Transform slendrinaLookPos;

	public GameObject slendrinaInFace;

	public GameObject slendrinaSkin;

	public GameObject slendrinaHair;

	public GameObject slendrinaEyes;

	public float speed;

	public Transform player;

	public Transform playerHead;

	public GameObject playerScript;

	public Transform playerEyes;

	public bool playerSeeSlendrina;

	public GameObject mouseLook;

	public GUITexture bloodScreen;

	public GUITexture rivenScreen;

	public GUITexture bloodScreenSlendrina;

	public float healthDecayRate;

	public float healthDecayRateRiven;

	public float healthDecayRateBlood;

	public float initialGreenLength;

	public float health;

	public float Tempohealth;

	public float differentHealtNumbers;

	public float differentHealtNumbersSlendrina;

	public float maxHealth;

	public GUITexture greenBar;

	public bool playerBleed;

	public bool playerRiven;

	public bool BloodScreen;

	public GameObject stopWalk;

	public GameObject animationHolder;

	public Transform playerHeadParent;

	public bool deadPlayer;

	public GameObject OptionButton;

	public AudioClip playerGethit;

	public bool seeSlendrinaFreeze;

	public GameObject swipeMovement;

	public bool seeSlendrinaGhost;

	public bool limit;

	public GameObject slendrinaAnim;

	public GameObject MusicHolder;

	public GameObject huntingMusicHolder;

	public GameObject screenSoundHolder;

	public GameObject playerStop;

	public GameObject gameController;

	public MonoBehaviour playerStopscript;

	private float healthDecayRateModifier;

	private float decayModifier;

	private float startingHealth;

	private float height100;

	public GameObject blackScreen;

	public GameObject blackScreenNewchance;

	public GameObject gameOverText;

	public bool playerIsDead;

	public float fadeSpeed;

	public bool tempBlock;

	public bool fadeMusic;

	public bool fadeSound;

	public bool healthFull;

	public GUITexture blackScreenNewChance;

	public float fadeBlackSpeed;

	public bool FadeAfterNo;

	public bool playerWillHaveNewChance;

	public bool slendrinaNotActive;

	public bool playerHealthBack;

	public float healthBackTid;

	public float healthBackTimer;

	public bool playerWon;

	public PlayerHealth()
	{
		speed = 20f;
		health = 100f;
		Tempohealth = 100f;
		maxHealth = 100f;
		playerBleed = true;
		playerRiven = true;
		healthDecayRateModifier = 0.2f;
		fadeSpeed = 1f;
	}

	public virtual void Start()
	{
		height100 = greenBar.transform.localScale.y;
		playerStop = GameObject.Find("Main Camera");
		playerStopscript = (MonoBehaviour)playerStop.GetComponent("CameraFollowExample");
		startingHealth = health;
		decayModifier = startingHealth / healthDecayRateBlood;
		Rect pixelInset = new Rect(0f, 0f, 0f, 0f);
		bloodScreen.GetComponent<GUITexture>().pixelInset = pixelInset;
		rivenScreen.GetComponent<GUITexture>().pixelInset = pixelInset;
		bloodScreenSlendrina.GetComponent<GUITexture>().pixelInset = pixelInset;
		GameObject gameObject = GameObject.Find("ScreenEffect");
		if ((bool)gameObject)
		{
		}
		float a = 0f;
		Color color = bloodScreen.color;
		float num = (color.a = a);
		Color color3 = (bloodScreen.color = color);
		float a2 = 0f;
		Color color4 = rivenScreen.color;
		float num2 = (color4.a = a2);
		Color color6 = (rivenScreen.color = color4);
		float a3 = 0f;
		Color color7 = bloodScreenSlendrina.color;
		float num3 = (color7.a = a3);
		Color color9 = (bloodScreenSlendrina.color = color7);
		health = maxHealth;
	}

	public virtual void Update()
	{
		target = GameObject.Find("LookAt");
		if (fadeMusic)
		{
			((PlayMusic)screenSoundHolder.GetComponent(typeof(PlayMusic))).fadeDown();
			if (!(((PlayMusic)screenSoundHolder.GetComponent(typeof(PlayMusic))).GetComponent<AudioSource>().volume > 0f))
			{
				fadeMusic = false;
			}
		}
		if (!(health < 100f))
		{
			healthFull = true;
			health = 100f;
		}
		if (!deadPlayer || deadPlayer)
		{
		}
		if (healthFull)
		{
			Tempohealth = 100f;
		}
		if (!tempBlock)
		{
			float y = height100 * health / 100f;
			Vector3 localScale = greenBar.transform.localScale;
			float num = (localScale.y = y);
			Vector3 vector2 = (greenBar.transform.localScale = localScale);
		}
		if (!(health < 80f))
		{
			greenBar.color = new Color(0.62745f, 0.82745f, 1f, 1f);
		}
		else if (!(health < 60f) && !(health > 80f))
		{
			greenBar.color = new Color(0.89412f, 0.53725f, 0.69804f, 1f);
		}
		else if (!(health < 40f) && !(health > 60f))
		{
			greenBar.color = new Color(0.784f, 0.286f, 0f, 1f);
		}
		else if (!(health < 20f) && !(health > 40f))
		{
			greenBar.color = new Color(0.784f, 0f, 0f, 1f);
		}
		else if (!(health < 0f) && !(health > 20f))
		{
			greenBar.color = new Color(0.7f, 0.2f, 0f, 1f);
		}
		if (!(health > 0f) && !deadPlayer)
		{
			StartCoroutine(playerDead());
		}
		if (!playerBleed)
		{
			float a = bloodScreen.color.a - healthDecayRate * Time.deltaTime;
			Color color = bloodScreen.color;
			float num2 = (color.a = a);
			Color color3 = (bloodScreen.color = color);
			if (!(bloodScreen.color.a >= 0f))
			{
				playerBleed = true;
			}
		}
		if (!playerRiven)
		{
			float a2 = rivenScreen.color.a - healthDecayRateRiven * Time.deltaTime;
			Color color4 = rivenScreen.color;
			float num3 = (color4.a = a2);
			Color color6 = (rivenScreen.color = color4);
			if (!(rivenScreen.color.a >= 0f))
			{
				playerRiven = true;
				rivenScreen.enabled = false;
			}
		}
		if (playerHealthBack)
		{
			if (!(healthBackTimer <= 0f))
			{
				healthBackTimer -= 1f * Time.deltaTime;
			}
			if (!(healthBackTimer > 0f))
			{
				health += 10f * Time.deltaTime;
				Tempohealth += 10f * Time.deltaTime;
				float a3 = bloodScreenSlendrina.color.a - 0.1f * Time.deltaTime;
				Color color7 = bloodScreenSlendrina.color;
				float num4 = (color7.a = a3);
				Color color9 = (bloodScreenSlendrina.color = color7);
			}
			if (!(health <= 100f))
			{
				healthBackTimer = healthBackTid;
				playerHealthBack = false;
				float a4 = 0f;
				Color color10 = bloodScreenSlendrina.color;
				float num5 = (color10.a = a4);
				Color color12 = (bloodScreenSlendrina.color = color10);
			}
		}
		if (!playerSeeSlendrina)
		{
			int num6 = 0;
			Vector3 eulerAngles = player.transform.eulerAngles;
			float num7 = (eulerAngles.x = num6);
			Vector3 vector4 = (player.transform.eulerAngles = eulerAngles);
			int num8 = 0;
			Vector3 eulerAngles2 = player.transform.eulerAngles;
			float num9 = (eulerAngles2.z = num8);
			Vector3 vector6 = (player.transform.eulerAngles = eulerAngles2);
		}
	}

	public virtual void HealthDecreaseBite()
	{
		healthBackTimer = healthBackTid;
		playerHealthBack = true;
		healthFull = false;
		bloodScreen.enabled = true;
		health -= differentHealtNumbers;
		Tempohealth -= differentHealtNumbers;
		playerBleed = true;
		float num = 0.2f;
		float num2 = 0.3f;
		float a = num;
		Color color = bloodScreen.color;
		float num3 = (color.a = a);
		Color color3 = (bloodScreen.color = color);
		float a2 = bloodScreenSlendrina.GetComponent<GUITexture>().color.a + 0.2f;
		Color color4 = bloodScreenSlendrina.GetComponent<GUITexture>().color;
		float num4 = (color4.a = a2);
		Color color6 = (bloodScreenSlendrina.GetComponent<GUITexture>().color = color4);
		StartCoroutine(HealthIncreaseBite());
	}

	public virtual void HealthDecreaseRiven()
	{
		healthBackTimer = healthBackTid;
		playerHealthBack = true;
		healthFull = false;
		rivenScreen.enabled = true;
		health -= differentHealtNumbers;
		Tempohealth -= differentHealtNumbers;
		playerRiven = true;
		float num = 0.2f;
		float num2 = 0.3f;
		float a = num2;
		Color color = rivenScreen.color;
		float num3 = (color.a = a);
		Color color3 = (rivenScreen.color = color);
		float a2 = bloodScreenSlendrina.GetComponent<GUITexture>().color.a + 0.2f;
		Color color4 = bloodScreenSlendrina.GetComponent<GUITexture>().color;
		float num4 = (color4.a = a2);
		Color color6 = (bloodScreenSlendrina.GetComponent<GUITexture>().color = color4);
		StartCoroutine(HealthIncreaseRiven());
	}

	public virtual void HealthDecreaseBlood()
	{
		if (!playerSeeSlendrina)
		{
			playerSeeSlendrina = true;
			mouseLook.GetComponent<MouseLook>().enabled = false;
		}
		((SkinnedMeshRenderer)slendrinaSkin.GetComponentInChildren(typeof(SkinnedMeshRenderer))).enabled = true;
		slendrinaHair.SetActive(true);
		slendrinaEyes.SetActive(true);
		healthBackTimer = healthBackTid;
		playerHealthBack = true;
		healthFull = false;
		slendrinaAnim.GetComponent<Animation>().Play("Attack");
		slendrinaAnim.GetComponent<Animation>()["Attack"].speed = 0.5f;
		if (!fadeMusic)
		{
			((PlayMusic)screenSoundHolder.GetComponent(typeof(PlayMusic))).fadeUp();
		}
		if (!(health <= 0f))
		{
			health -= healthDecayRateBlood * Time.deltaTime;
			Tempohealth -= healthDecayRateBlood * Time.deltaTime;
		}
		float num = 1f - Tempohealth / startingHealth;
		float a = num;
		Color color = bloodScreenSlendrina.color;
		float num2 = (color.a = a);
		Color color3 = (bloodScreenSlendrina.color = color);
	}

	public virtual IEnumerator HealthIncreaseBite()
	{
		return new _0024HealthIncreaseBite_0024372(this).GetEnumerator();
	}

	public virtual IEnumerator HealthIncreaseRiven()
	{
		return new _0024HealthIncreaseRiven_0024375(this).GetEnumerator();
	}

	public virtual void HealthIncreaseBlood()
	{
		if (!((checkOngoing)gameController.GetComponent(typeof(checkOngoing))).onGoing)
		{
			mouseLook.GetComponent<MouseLook>().enabled = true;
		}
		playerSeeSlendrina = false;
		((SkinnedMeshRenderer)slendrinaSkin.GetComponentInChildren(typeof(SkinnedMeshRenderer))).enabled = false;
		slendrinaHair.SetActive(false);
		slendrinaEyes.SetActive(false);
		if (!healthFull)
		{
			float num = 1f - Tempohealth / startingHealth;
			((PlayMusic)screenSoundHolder.GetComponent(typeof(PlayMusic))).fadeDown();
			if (!(Tempohealth < 100f))
			{
				Tempohealth = 100f;
			}
		}
	}

	public virtual IEnumerator playerDead()
	{
		return new _0024playerDead_0024378(this).GetEnumerator();
	}

	public virtual void faceGhost()
	{
		if (!seeSlendrinaFreeze && !deadPlayer)
		{
			Quaternion b = Quaternion.LookRotation(slendrinaLookPos.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2, Screen.height / 2, Camera.main.nearClipPlane)));
			transform.rotation = Quaternion.Slerp(transform.rotation, b, Time.deltaTime * speed);
			playerHead.transform.rotation = Quaternion.Slerp(playerHead.transform.rotation, b, Time.deltaTime * speed);
			StartCoroutine(seeSlendrina());
		}
	}

	public virtual IEnumerator seeSlendrina()
	{
		return new _0024seeSlendrina_0024381(this).GetEnumerator();
	}

	public virtual IEnumerator Fade(float startLevel, float endLevel, float duration)
	{
		return new _0024Fade_0024384(startLevel, endLevel, this).GetEnumerator();
	}

	public virtual void Main()
	{
	}
}
