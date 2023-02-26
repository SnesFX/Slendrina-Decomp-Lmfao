using System;
using UnityEngine;

[Serializable]
public class RandomObjectPlace : MonoBehaviour
{
	public GameObject object1;

	public GameObject object2;

	public GameObject object3;

	public GameObject object4;

	public GameObject object5;

	public int number;

	public virtual void Start()
	{
		number = UnityEngine.Random.Range(1, 6);
		Debug.Log(number);
		if (number == 1)
		{
			object1.SetActive(true);
			object2.SetActive(false);
			object3.SetActive(false);
			object4.SetActive(false);
			object5.SetActive(false);
		}
		else if (number == 2)
		{
			object2.SetActive(true);
			object1.SetActive(false);
			object3.SetActive(false);
			object4.SetActive(false);
			object5.SetActive(false);
		}
		else if (number == 3)
		{
			object3.SetActive(true);
			object1.SetActive(false);
			object2.SetActive(false);
			object4.SetActive(false);
			object5.SetActive(false);
		}
		else if (number == 4)
		{
			object4.SetActive(true);
			object1.SetActive(false);
			object2.SetActive(false);
			object3.SetActive(false);
			object5.SetActive(false);
		}
		else if (number == 5)
		{
			object5.SetActive(true);
			object1.SetActive(false);
			object2.SetActive(false);
			object3.SetActive(false);
			object4.SetActive(false);
		}
	}

	public virtual void Main()
	{
	}
}
