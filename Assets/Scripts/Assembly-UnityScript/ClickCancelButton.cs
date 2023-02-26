using System;
using UnityEngine;

[Serializable]
public class ClickCancelButton : MonoBehaviour
{
	public GameObject button;

	public GameObject quitGameMenu;

	public GameObject audioStop;

	public GameObject ljudHolder;

	public GameObject slendrina;

	public GameObject playerScript;

	public GameObject mouseLook;

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
		Time.timeScale = 1f;
		AudioListener.pause = false;
		button.transform.localScale = new Vector3(0.23f, 0.2f, 1f);
		quitGameMenu.SetActive(false);
		((soundEffects)ljudHolder.GetComponent(typeof(soundEffects))).buttonClick();
		slendrina.SetActive(true);
		Cursor.visible = false;
		Screen.lockCursor = true;
		playerScript.GetComponent<FPSInputController>().enabled = true;
		playerScript.GetComponent<MouseLook>().enabled = true;
		mouseLook.GetComponent<MouseLook>().enabled = true;
		((SensitivitySlider)mouseLook.GetComponent(typeof(SensitivitySlider))).enabled = false;
	}

	public virtual void Main()
	{
	}
}
