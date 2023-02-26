using System;
using UnityEngine;

[Serializable]
public class FlyingHink : MonoBehaviour
{
	public GameObject animationHolder;

	public GameObject soundHolder;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			((soundEffects)soundHolder.GetComponent(typeof(soundEffects))).FlyingHink();
			animationHolder.GetComponent<Animation>().Play("FlyingHink");
			UnityEngine.Object.Destroy(gameObject);
		}
	}

	public virtual void Main()
	{
	}
}
