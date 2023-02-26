using System;
using UnityEngine;

[Serializable]
public class ScreamSound : MonoBehaviour
{
	public AudioClip femaleLjud;

	public AudioClip catLjud;

	public GameObject female;

	public GameObject cat;

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "femaletrigger")
		{
			AudioSource.PlayClipAtPoint(femaleLjud, transform.position);
			UnityEngine.Object.Destroy(female);
		}
		if (other.gameObject.tag == "cattrigger")
		{
			AudioSource.PlayClipAtPoint(catLjud, transform.position);
			UnityEngine.Object.Destroy(cat);
		}
	}

	public virtual void Main()
	{
	}
}
