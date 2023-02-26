using System;
using UnityEngine;

[Serializable]
public class PickUpKey : MonoBehaviour
{
	public GameObject scriptHolder;

	public AudioClip pickup;

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "key")
		{
			((CountKey)scriptHolder.GetComponent(typeof(CountKey))).countUpKey();
			AudioSource.PlayClipAtPoint(pickup, transform.position);
			UnityEngine.Object.Destroy(other.gameObject);
		}
	}

	public virtual void Main()
	{
	}
}
