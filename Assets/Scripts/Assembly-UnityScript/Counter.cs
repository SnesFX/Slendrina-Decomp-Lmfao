using System;
using UnityEngine;

[Serializable]
public class Counter : MonoBehaviour
{
	public Texture zero;

	public Texture one;

	public Texture two;

	public Texture tree;

	public Texture four;

	public Texture five;

	public Texture six;

	public Texture seven;

	public Texture eight;

	public float counter;

	public GameObject wellDoneText;

	public virtual void Start()
	{
		GetComponent<GUITexture>().texture = zero;
	}

	public virtual void Update()
	{
	}

	public virtual void countUp()
	{
		if (GetComponent<GUITexture>().texture == zero)
		{
			GetComponent<GUITexture>().texture = one;
			counter += 1f;
		}
		else if (GetComponent<GUITexture>().texture == one)
		{
			GetComponent<GUITexture>().texture = two;
			counter += 1f;
		}
		else if (GetComponent<GUITexture>().texture == two)
		{
			GetComponent<GUITexture>().texture = tree;
			counter += 1f;
		}
		else if (GetComponent<GUITexture>().texture == tree)
		{
			GetComponent<GUITexture>().texture = four;
			counter += 1f;
		}
		else if (GetComponent<GUITexture>().texture == four)
		{
			GetComponent<GUITexture>().texture = five;
			counter += 1f;
		}
		else if (GetComponent<GUITexture>().texture == five)
		{
			GetComponent<GUITexture>().texture = six;
			counter += 1f;
		}
		else if (GetComponent<GUITexture>().texture == six)
		{
			GetComponent<GUITexture>().texture = seven;
			counter += 1f;
		}
		else if (GetComponent<GUITexture>().texture == seven)
		{
			GetComponent<GUITexture>().texture = eight;
			counter += 1f;
			wellDoneText.SetActive(true);
		}
	}

	public virtual void Main()
	{
	}
}
