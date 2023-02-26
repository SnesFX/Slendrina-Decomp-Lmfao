using System;
using UnityEngine;

[Serializable]
public class DestroyGate : MonoBehaviour
{
	public virtual void destroyGate()
	{
		UnityEngine.Object.Destroy(gameObject);
	}

	public virtual void Main()
	{
	}
}
