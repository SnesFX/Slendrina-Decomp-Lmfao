using System;
using UnityEngine;

[Serializable]
public class TriggerDoorSlam : MonoBehaviour
{
	public GameObject animationHolder;

	public GameObject soundHolder;

	public GameObject slendrinaHead;

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			((soundEffects)soundHolder.GetComponent(typeof(soundEffects))).slamDoor();
			animationHolder.GetComponent<Animation>().Play("DoorSlam");
			UnityEngine.Object.Destroy(slendrinaHead);
			UnityEngine.Object.Destroy(gameObject);
		}
	}

	public virtual void Main()
	{
	}
}
