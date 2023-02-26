using System;
using UnityEngine;

[Serializable]
public class ChangeScene : MonoBehaviour
{
	public GameObject congratText;

	public GameObject stopMovement;

	public GameObject stopGirl;

	public GameObject touchArea;

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "TheEnd")
		{
			congratText.SetActive(true);
			((FPScontroller)stopMovement.GetComponent(typeof(FPScontroller))).enabled = false;
			stopGirl.SetActive(false);
			touchArea.SetActive(false);
		}
	}

	public virtual void Main()
	{
	}
}
