using System;
using UnityEngine;

[Serializable]
public class CountKey : MonoBehaviour
{
	public int keys;

	public Texture zero;

	public Texture one;

	public Texture two;

	public Texture tree;

	public Texture four;

	public Texture five;

	public Texture six;

	public virtual void Start()
	{
		GetComponent<GUITexture>().texture = zero;
	}

	public virtual void Update()
	{
		if (keys == 1)
		{
			GetComponent<GUITexture>().texture = one;
		}
		else if (keys == 2)
		{
			GetComponent<GUITexture>().texture = two;
		}
		else if (keys == 3)
		{
			GetComponent<GUITexture>().texture = tree;
		}
		else if (keys == 4)
		{
			GetComponent<GUITexture>().texture = four;
		}
		else if (keys == 5)
		{
			GetComponent<GUITexture>().texture = five;
		}
		else if (keys == 6)
		{
			GetComponent<GUITexture>().texture = six;
		}
		else if (keys == 0)
		{
			GetComponent<GUITexture>().texture = zero;
		}
	}

	public virtual void countUpKey()
	{
		keys++;
	}

	public virtual void countDownKey()
	{
		keys--;
	}

	public virtual void Main()
	{
	}
}
