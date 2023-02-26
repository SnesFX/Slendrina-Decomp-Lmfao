using System;
using UnityEngine;

[Serializable]
public class BetweenScenesValues : MonoBehaviour
{
	[NonSerialized]
	public static bool difficultyEasy;

	[NonSerialized]
	public static bool difficultyMedium;

	[NonSerialized]
	public static bool difficultyHard;

	public virtual void Awake()
	{
		UnityEngine.Object.DontDestroyOnLoad(transform.gameObject);
	}

	public virtual void Main()
	{
	}
}
