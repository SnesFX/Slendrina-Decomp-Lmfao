using System;
using UnityEngine;

[Serializable]
public class SlendrinaCrawlTrigger : MonoBehaviour
{
	public GameObject crawlMan;

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			crawlMan.SetActive(true);
			UnityEngine.Object.Destroy(gameObject);
		}
	}

	public virtual void Main()
	{
	}
}
