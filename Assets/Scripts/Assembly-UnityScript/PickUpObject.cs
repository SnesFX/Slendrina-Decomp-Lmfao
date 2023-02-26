using System;
using UnityEngine;

[Serializable]
public class PickUpObject : MonoBehaviour
{
	public GameObject pickUpHand;

	public AudioClip pickUpBook;

	public AudioClip pickUpKey;

	public GameObject keyCounter;

	public GameObject bookCounter;

	public float seeLenght;

	public virtual void Update()
	{
		RaycastHit hitInfo = default(RaycastHit);
		if (Physics.Raycast(transform.position, transform.forward, out hitInfo, seeLenght))
		{
			if (hitInfo.collider.gameObject.tag == "book")
			{
				pickUpHand.SetActive(true);
				if (Input.GetKeyDown("e"))
				{
					AudioSource.PlayClipAtPoint(pickUpBook, transform.position);
					((Counter)bookCounter.GetComponent(typeof(Counter))).countUp();
					pickUpHand.SetActive(false);
					UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
				}
			}
			else if (hitInfo.collider.gameObject.tag == "key")
			{
				pickUpHand.SetActive(true);
				if (Input.GetKeyDown("e"))
				{
					AudioSource.PlayClipAtPoint(pickUpKey, transform.position);
					((CountKey)keyCounter.GetComponent(typeof(CountKey))).countUpKey();
					pickUpHand.SetActive(false);
					UnityEngine.Object.Destroy(hitInfo.collider.gameObject);
				}
			}
			else
			{
				pickUpHand.SetActive(false);
			}
		}
		else
		{
			pickUpHand.SetActive(false);
		}
	}

	public virtual void Main()
	{
	}
}
