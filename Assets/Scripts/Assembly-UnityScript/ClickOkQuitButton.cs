using System;
using UnityEngine;

[Serializable]
public class ClickOkQuitButton : MonoBehaviour
{
	public GameObject ljudHolder;

	public GameObject button;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
	}

	public virtual void OnMouseEnter()
	{
		button.transform.localScale = new Vector3(0.24f, 0.2f, 1f);
		((soundEffects)ljudHolder.GetComponent(typeof(soundEffects))).overButton();
	}

	public virtual void OnMouseExit()
	{
		button.transform.localScale = new Vector3(0.23f, 0.2f, 1f);
		((soundEffects)ljudHolder.GetComponent(typeof(soundEffects))).overButton();
	}

	public virtual void OnMouseDown()
	{
		button.transform.localScale = new Vector3(0.23f, 0.2f, 1f);
		((soundEffects)ljudHolder.GetComponent(typeof(soundEffects))).buttonClick();
		Application.LoadLevel("Menu");
	}

	public virtual void Main()
	{
	}
}
