using System;
using UnityEngine;

[Serializable]
public class PlayGirlHangRope : MonoBehaviour
{
	public virtual void Start()
	{
		GetComponent<Animation>().Play("Gunga");
	}

	public virtual void Main()
	{
	}
}
