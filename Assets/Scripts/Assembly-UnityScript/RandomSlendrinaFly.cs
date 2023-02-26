using System;
using UnityEngine;

[Serializable]
public class RandomSlendrinaFly : MonoBehaviour
{
	public GameObject object1;

	public GameObject object2;

	public GameObject object3;

	public int number;

	public virtual void Start()
	{
		number = UnityEngine.Random.Range(1, 4);
		Debug.Log(number);
		if (number == 1)
		{
			object1.SetActive(true);
			object2.SetActive(false);
			object3.SetActive(false);
		}
		else if (number == 2)
		{
			object2.SetActive(true);
			object1.SetActive(false);
			object3.SetActive(false);
		}
		else if (number == 3)
		{
			object3.SetActive(true);
			object1.SetActive(false);
			object2.SetActive(false);
		}
	}

	public virtual void Main()
	{
	}
}
