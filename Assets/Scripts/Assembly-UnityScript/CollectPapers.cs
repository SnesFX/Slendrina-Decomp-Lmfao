using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
[RequireComponent(typeof(AudioSource))]
public class CollectPapers : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024DisplayPaper_0024448 : GenericGenerator<object>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<object>, IEnumerator
		{
			internal float _0024scaleTimer_0024449;

			internal bool _0024isScaling_0024450;

			internal float _0024scaleFactor_0024451;

			internal float _0024newPosY_0024452;

			internal float _0024_0024258_0024453;

			internal Vector3 _0024_0024259_0024454;

			internal float _0024_0024260_0024455;

			internal Vector3 _0024_0024261_0024456;

			internal float _0024_0024262_0024457;

			internal Vector3 _0024_0024263_0024458;

			internal CollectPapers _0024self__0024459;

			public _0024(CollectPapers self_)
			{
				_0024self__0024459 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__0024459.paperDisplayObject.localPosition = _0024self__0024459.startPos;
					_0024self__0024459.paperDisplayObject.localScale = _0024self__0024459.startScale;
					_0024self__0024459.paperDisplayParticles.transform.localPosition = _0024self__0024459.particleStartPos;
					_0024self__0024459.paperDisplayObject.GetComponent<Renderer>().material = _0024self__0024459.currentPaperMaterial;
					_0024self__0024459.paperDisplayObject.GetComponent<Renderer>().enabled = true;
					_0024self__0024459.paperDisplayLight.enabled = true;
					_0024self__0024459.paperDisplayParticles.emit = true;
					_0024scaleTimer_0024449 = 0f;
					_0024isScaling_0024450 = true;
					goto case 2;
				case 2:
					if (_0024isScaling_0024450)
					{
						_0024scaleTimer_0024449 += Time.deltaTime;
						if (!(_0024scaleTimer_0024449 <= _0024self__0024459.scaleTimerMax))
						{
							_0024isScaling_0024450 = false;
						}
						_0024scaleFactor_0024451 = (_0024self__0024459.scaleTimerMax - _0024scaleTimer_0024449) / _0024self__0024459.scaleTimerMax;
						float num = (_0024_0024258_0024453 = _0024self__0024459.startScale.y * _0024scaleFactor_0024451);
						Vector3 vector = (_0024_0024259_0024454 = _0024self__0024459.paperDisplayObject.localScale);
						float num2 = (_0024_0024259_0024454.y = _0024_0024258_0024453);
						Vector3 vector3 = (_0024self__0024459.paperDisplayObject.localScale = _0024_0024259_0024454);
						_0024newPosY_0024452 = _0024self__0024459.startPos.y + (_0024self__0024459.startScale.y * 0.5f - _0024self__0024459.paperDisplayObject.localScale.y * 0.5f);
						float num3 = (_0024_0024260_0024455 = _0024newPosY_0024452);
						Vector3 vector4 = (_0024_0024261_0024456 = _0024self__0024459.paperDisplayObject.localPosition);
						float num4 = (_0024_0024261_0024456.y = _0024_0024260_0024455);
						Vector3 vector6 = (_0024self__0024459.paperDisplayObject.localPosition = _0024_0024261_0024456);
						float num5 = (_0024_0024262_0024457 = _0024self__0024459.particleStartPos.y + (_0024self__0024459.startScale.y - _0024self__0024459.paperDisplayObject.localScale.y));
						Vector3 vector7 = (_0024_0024263_0024458 = _0024self__0024459.paperDisplayParticles.transform.localPosition);
						float num6 = (_0024_0024263_0024458.y = _0024_0024262_0024457);
						Vector3 vector9 = (_0024self__0024459.paperDisplayParticles.transform.localPosition = _0024_0024263_0024458);
						_0024self__0024459.currentPaperMaterial.mainTextureScale = new Vector2(1f, _0024scaleFactor_0024451);
						_0024self__0024459.currentPaperMaterial.SetTextureOffset("_MainTex", new Vector2(0f, 1f - _0024scaleFactor_0024451));
						result = (YieldDefault(2) ? 1 : 0);
						break;
					}
					_0024self__0024459.paperDisplayObject.GetComponent<Renderer>().enabled = false;
					_0024self__0024459.paperDisplayLight.enabled = false;
					_0024self__0024459.paperDisplayParticles.emit = false;
					_0024self__0024459.currentPaperMaterial.mainTextureScale = Vector2.one;
					_0024self__0024459.currentPaperMaterial.SetTextureOffset("_MainTex", Vector2.zero);
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal CollectPapers _0024self__0024460;

		public _0024DisplayPaper_0024448(CollectPapers self_)
		{
			_0024self__0024460 = self_;
		}

		public override IEnumerator<object> GetEnumerator()
		{
			return new _0024(_0024self__0024460);
		}
	}

	public int papers;

	public int papersToWin;

	public float distanceToPaper;

	public float sphereRadius;

	public float scaleTimerMax;

	public AudioClip paperSound;

	public NPCMovement enemyScript;

	public MusicManager musicManagerScript;

	private Material currentPaperMaterial;

	public Transform paperDisplayObject;

	public Light paperDisplayLight;

	public ParticleEmitter paperDisplayParticles;

	private Vector3 startPos;

	private Vector3 startScale;

	private Vector3 particleStartPos;

	public CollectPapers()
	{
		papersToWin = 8;
		distanceToPaper = 5.5f;
		sphereRadius = 1f;
		scaleTimerMax = 1.5f;
	}

	public virtual void Start()
	{
		if (!enemyScript)
		{
			Debug.LogWarning("No Enemy Script in the Inspector");
			GameObject gameObject = GameObject.Find("Enemy");
			enemyScript = (NPCMovement)gameObject.GetComponent(typeof(NPCMovement));
		}
		if (!musicManagerScript)
		{
			Debug.LogWarning("No Music Manager Script in the Inspector");
			GameObject gameObject2 = GameObject.Find("MusicManager");
			musicManagerScript = (MusicManager)gameObject2.GetComponent(typeof(MusicManager));
		}
		if (!paperDisplayObject)
		{
			Debug.LogWarning("No paper Display Object in the Inspector");
			paperDisplayObject = GameObject.Find("PaperDisplayObject").transform;
		}
		if (!paperDisplayLight)
		{
			Debug.LogWarning("No paper Display Light in the Inspector");
			paperDisplayLight = GameObject.Find("PaperViewSpotlight").GetComponent<Light>();
		}
		if (!paperDisplayParticles)
		{
			Debug.LogWarning("No paper Display Particles in the Inspector");
			paperDisplayParticles = GameObject.Find("DustParticleEffect").GetComponent<ParticleEmitter>();
		}
		paperDisplayObject.GetComponent<Renderer>().enabled = false;
		paperDisplayLight.enabled = false;
		paperDisplayParticles.emit = false;
		particleStartPos = paperDisplayParticles.transform.localPosition;
		startPos = paperDisplayObject.localPosition;
		startScale = paperDisplayObject.localScale;
	}

	public virtual void Update()
	{
		if (!Input.GetMouseButtonDown(0) && !Input.GetKeyDown(KeyCode.E))
		{
			return;
		}
		RaycastHit hitInfo = default(RaycastHit);
		Ray ray = Camera.main.ScreenPointToRay(new Vector3((float)Screen.width * 0.5f, (float)Screen.height * 0.5f, 0f));
		if (Physics.SphereCast(ray, sphereRadius, out hitInfo, distanceToPaper) && hitInfo.collider.gameObject.name == "Paper")
		{
			papers++;
			AudioSource.PlayClipAtPoint(paperSound, hitInfo.point);
			UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
			enemyScript.ReduceDistance();
			enemyScript.TeleportEnemy();
			gameObject.SendMessage("DecreaseHealthDecayRate", SendMessageOptions.RequireReceiver);
			if (papers == 2)
			{
				musicManagerScript.PlayMusicTrack(1);
			}
			else if (papers == 4)
			{
				musicManagerScript.PlayMusicTrack(2);
			}
			else if (papers == 6)
			{
				musicManagerScript.PlayMusicTrack(3);
			}
			else if (papers == papersToWin)
			{
				Debug.Log("You have collected All Papers !");
				Application.LoadLevel("SceneWin");
			}
			currentPaperMaterial = hitInfo.collider.gameObject.GetComponent<Renderer>().material;
			StartCoroutine(DisplayPaper());
		}
	}

	public virtual IEnumerator DisplayPaper()
	{
		return new _0024DisplayPaper_0024448(this).GetEnumerator();
	}

	public virtual void Main()
	{
	}
}
