using System;
using UnityEngine;

[Serializable]
public class SaveSensitivityData : MonoBehaviour
{
	[NonSerialized]
	public static float sliderValue = 5f;

	public virtual void Awake()
	{
		UnityEngine.Object.DontDestroyOnLoad(transform.gameObject);
	}

	public virtual void Main()
	{
	}
}
