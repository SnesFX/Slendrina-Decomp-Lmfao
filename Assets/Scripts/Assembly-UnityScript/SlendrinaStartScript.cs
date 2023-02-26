using System;
using UnityEngine;

[Serializable]
public class SlendrinaStartScript : MonoBehaviour
{
	public GameObject slendrinaVisible;

	public GameObject slendrinaActive;

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			slendrinaActive.SetActive(true);
			slendrinaVisible.SetActive(true);
		}
	}

	public virtual void Main()
	{
	}
}
