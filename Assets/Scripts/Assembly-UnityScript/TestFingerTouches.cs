using System;
using UnityEngine;

[Serializable]
public class TestFingerTouches : MonoBehaviour
{
	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		if (Input.touches.Length == 1)
		{
			Debug.Log(" " + Input.touches[0].fingerId);
		}
		if (Input.touches.Length == 2)
		{
			Debug.Log(" " + Input.touches[0].fingerId + " " + Input.touches[1].fingerId);
		}
		if (Input.touches.Length == 3)
		{
			Debug.Log(" " + Input.touches[0].fingerId + " " + Input.touches[1].fingerId + " " + Input.touches[2].fingerId);
		}
	}

	public virtual void Main()
	{
	}
}
