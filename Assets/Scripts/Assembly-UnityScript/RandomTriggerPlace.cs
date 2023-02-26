using System;
using UnityEngine;

[Serializable]
public class RandomTriggerPlace : MonoBehaviour
{
	public GameObject trigger1;

	public GameObject trigger2;

	public GameObject trigger3;

	public int number;

	public virtual void Start()
	{
		number = UnityEngine.Random.Range(1, 4);
		Debug.Log(number);
		if (number == 1)
		{
			trigger1.SetActive(true);
			trigger2.SetActive(false);
			trigger3.SetActive(false);
		}
		else if (number == 2)
		{
			trigger2.SetActive(true);
			trigger1.SetActive(false);
			trigger3.SetActive(false);
		}
		else if (number == 3)
		{
			trigger3.SetActive(true);
			trigger1.SetActive(false);
			trigger2.SetActive(false);
		}
	}

	public virtual void Main()
	{
	}
}
