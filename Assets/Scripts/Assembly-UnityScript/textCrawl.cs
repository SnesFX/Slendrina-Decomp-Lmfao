using System;
using UnityEngine;

[Serializable]
public class textCrawl : MonoBehaviour
{
	public bool travelDown;

	public float timer;

	public textCrawl()
	{
		timer = 2f;
	}

	public virtual void Start()
	{
		float y = -0.88f;
		Vector3 localPosition = transform.localPosition;
		float num = (localPosition.y = y);
		Vector3 vector2 = (transform.localPosition = localPosition);
		travelDown = true;
	}

	public virtual void Update()
	{
		if (travelDown)
		{
			timer -= Time.deltaTime;
		}
		if (!(timer >= 0f))
		{
			travelDown = false;
			timer = 2f;
			float y = -0.88f;
			Vector3 localPosition = transform.localPosition;
			float num = (localPosition.y = y);
			Vector3 vector2 = (transform.localPosition = localPosition);
			gameObject.SetActive(false);
		}
	}

	public virtual void Main()
	{
	}
}
