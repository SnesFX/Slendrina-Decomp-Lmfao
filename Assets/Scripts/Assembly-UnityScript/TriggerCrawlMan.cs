using System;
using UnityEngine;

[Serializable]
public class TriggerCrawlMan : MonoBehaviour
{
	public GameObject crawlMan;

	public GameObject stopSlendrina;

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			stopSlendrina.SetActive(false);
			crawlMan.SetActive(true);
			UnityEngine.Object.Destroy(gameObject);
		}
	}

	public virtual void Main()
	{
	}
}
