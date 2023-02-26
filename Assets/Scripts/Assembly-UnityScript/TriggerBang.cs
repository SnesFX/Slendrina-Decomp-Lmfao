using System;
using UnityEngine;

[Serializable]
public class TriggerBang : MonoBehaviour
{
	public GameObject soundHolder;

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			((soundEffects)soundHolder.GetComponent(typeof(soundEffects))).bangLjud();
			UnityEngine.Object.Destroy(gameObject);
		}
	}

	public virtual void Main()
	{
	}
}
