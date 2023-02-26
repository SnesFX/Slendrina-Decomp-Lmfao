using System;
using UnityEngine;

[Serializable]
public class QuitApplication : MonoBehaviour
{
	public GameObject button;

	public GameObject ljudHolder;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
	}

	public virtual void OnMouseEnter()
	{
		button.transform.localScale = new Vector3(0.16f, 0.13f, 1f);
		((MenuSounds)ljudHolder.GetComponent(typeof(MenuSounds))).buttonOver();
	}

	public virtual void OnMouseExit()
	{
		button.transform.localScale = new Vector3(0.15f, 0.13f, 1f);
		((MenuSounds)ljudHolder.GetComponent(typeof(MenuSounds))).buttonOver();
	}

	public virtual void OnMouseDown()
	{
		((MenuSounds)ljudHolder.GetComponent(typeof(MenuSounds))).buttonClick();
		Application.Quit();
	}

	public virtual void Main()
	{
	}
}
