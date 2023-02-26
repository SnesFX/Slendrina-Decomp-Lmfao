using System;
using UnityEngine;

[Serializable]
public class HeadTavlaTrigger : MonoBehaviour
{
	public GameObject animationHolder;

	public GameObject soundHolder;

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			((soundEffects)soundHolder.GetComponent(typeof(soundEffects))).tavla();
			animationHolder.SetActive(true);
			UnityEngine.Object.Destroy(gameObject);
		}
	}

	public virtual void Main()
	{
	}
}
