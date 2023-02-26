using System;
using UnityEngine;

[Serializable]
public class GardeDoorOpen : MonoBehaviour
{
	public bool doorOpen;

	public virtual void Update()
	{
		if (!doorOpen)
		{
			if (GetComponent<Animation>().IsPlaying("openH"))
			{
				doorOpen = true;
				gameObject.tag = "Untagged";
			}
			else if (GetComponent<Animation>().IsPlaying("openV"))
			{
				doorOpen = true;
				gameObject.tag = "Untagged";
			}
		}
	}

	public virtual void Main()
	{
	}
}
