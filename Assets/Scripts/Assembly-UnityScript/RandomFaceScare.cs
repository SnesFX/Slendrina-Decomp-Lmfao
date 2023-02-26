using System;
using UnityEngine;

[Serializable]
public class RandomFaceScare : MonoBehaviour
{
	public GameObject face1;

	public GameObject face2;

	public GameObject face3;

	public int number;

	public virtual void Start()
	{
		number = UnityEngine.Random.Range(1, 4);
		Debug.Log(number);
		if (number == 1)
		{
			face1.SetActive(true);
			face2.SetActive(false);
			face3.SetActive(false);
		}
		else if (number == 2)
		{
			face2.SetActive(true);
			face1.SetActive(false);
			face3.SetActive(false);
		}
		else if (number == 3)
		{
			face3.SetActive(true);
			face1.SetActive(false);
			face2.SetActive(false);
		}
	}

	public virtual void Main()
	{
	}
}
