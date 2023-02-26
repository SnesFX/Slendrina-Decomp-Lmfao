using System;
using UnityEngine;

[Serializable]
public class GateIsClosedText : MonoBehaviour
{
	public GameObject gateIsLockedText;

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Gate")
		{
			gateIsLockedText.SetActive(true);
		}
	}

	public virtual void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Gate")
		{
			gateIsLockedText.SetActive(false);
		}
	}

	public virtual void Main()
	{
	}
}
