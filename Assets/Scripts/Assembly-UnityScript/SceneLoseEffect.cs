using System;
using UnityEngine;

[Serializable]
public class SceneLoseEffect : MonoBehaviour
{
	public Transform enemyObject;

	public Renderer staticObject;

	public Renderer btnMainMenu;

	public Renderer btnOptions;

	public Renderer btnQuit;

	public Renderer labelTitle;

	public loseMenuState currState;

	public float timer;

	public float enemyAppearTime;

	public float staticGoRedTime;

	public float staticFadeAwayTime;

	public float enemyAppearSpeed;

	public SceneLoseEffect()
	{
		enemyAppearTime = 1.5f;
		staticGoRedTime = 2f;
		staticFadeAwayTime = 2f;
		enemyAppearSpeed = 1.5f;
	}

	public virtual void Start()
	{
		if (!enemyObject)
		{
			Debug.LogWarning("No Enemy Object in the Inspector");
			enemyObject = GameObject.Find("golem").transform;
		}
		if (!staticObject)
		{
			Debug.LogWarning("No Static Object in the Inspector");
			staticObject = GameObject.Find("StaticObject").GetComponent<Renderer>();
		}
		float a = 1f;
		Color color = staticObject.material.color;
		float num = (color.a = a);
		Color color3 = (staticObject.material.color = color);
		if (!btnMainMenu)
		{
			Debug.LogWarning("No btnMainMenu in the Inspector");
			btnMainMenu = GameObject.Find("BtnMainMenu").GetComponent<Renderer>();
		}
		if (!btnOptions)
		{
			Debug.LogWarning("No btnOptions in the Inspector");
			btnOptions = GameObject.Find("BtnOptions").GetComponent<Renderer>();
		}
		if (!btnQuit)
		{
			Debug.LogWarning("No btnQuit in the Inspector");
			btnQuit = GameObject.Find("BtnQuit").GetComponent<Renderer>();
		}
		if (!labelTitle)
		{
			Debug.LogWarning("No labelTitle in the Inspector");
			labelTitle = GameObject.Find("Title").GetComponent<Renderer>();
		}
		ShowMenuItems(false);
		timer = 0f;
		currState = loseMenuState.EnemyAppear;
	}

	public virtual void Update()
	{
		OffsetMainTexture();
		timer += Time.deltaTime;
		float num = default(float);
		switch (currState)
		{
		case loseMenuState.EnemyAppear:
		{
			float z3 = enemyObject.localPosition.z - enemyAppearSpeed * Time.deltaTime;
			Vector3 localPosition3 = enemyObject.localPosition;
			float num7 = (localPosition3.z = z3);
			Vector3 vector6 = (enemyObject.localPosition = localPosition3);
			if (!(timer <= enemyAppearTime))
			{
				timer = 0f;
				currState = loseMenuState.EnemyDisappear;
			}
			break;
		}
		case loseMenuState.EnemyDisappear:
		{
			float z = -10f;
			Vector3 localPosition = enemyObject.localPosition;
			float num3 = (localPosition.z = z);
			Vector3 vector2 = (enemyObject.localPosition = localPosition);
			timer = 0f;
			currState = loseMenuState.StaticGoRed;
			break;
		}
		case loseMenuState.StaticGoRed:
		{
			num = timer / staticGoRedTime;
			float b = 1f - num;
			Color color4 = staticObject.material.color;
			float num4 = (color4.b = b);
			Color color6 = (staticObject.material.color = color4);
			float g = 1f - num;
			Color color7 = staticObject.material.color;
			float num5 = (color7.g = g);
			Color color9 = (staticObject.material.color = color7);
			if (!(timer <= staticGoRedTime))
			{
				timer = 0f;
				float z2 = 0.6f;
				Vector3 localPosition2 = staticObject.transform.localPosition;
				float num6 = (localPosition2.z = z2);
				Vector3 vector4 = (staticObject.transform.localPosition = localPosition2);
				staticObject.transform.localScale = new Vector3(0.2f, 1f, 0.15f);
				ShowMenuItems(true);
				currState = loseMenuState.StaticFadeAway;
			}
			break;
		}
		case loseMenuState.StaticFadeAway:
		{
			num = timer / staticFadeAwayTime;
			float a = 1f - num;
			Color color = staticObject.material.color;
			float num2 = (color.a = a);
			Color color3 = (staticObject.material.color = color);
			if (!(timer <= staticFadeAwayTime))
			{
				timer = 0f;
				currState = loseMenuState.WaitingForInput;
			}
			break;
		}
		}
	}

	public virtual void OffsetMainTexture()
	{
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		staticObject.material.mainTextureOffset = new Vector2(value, value2);
	}

	public virtual void ShowMenuItems(bool theBool)
	{
		btnMainMenu.enabled = theBool;
		btnOptions.enabled = theBool;
		btnQuit.enabled = theBool;
		labelTitle.enabled = theBool;
		btnMainMenu.gameObject.GetComponent<Collider>().enabled = theBool;
		btnOptions.gameObject.GetComponent<Collider>().enabled = theBool;
		btnQuit.gameObject.GetComponent<Collider>().enabled = theBool;
	}

	public virtual void Main()
	{
	}
}
