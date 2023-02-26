using System;
using UnityEngine;

[Serializable]
public class PressBackButton : MonoBehaviour
{
	public GameObject quitGameMenu;

	public GameObject slendrina;

	public GameObject playerScript;

	public GameObject mouseLook;

	public GameObject animationHolder;

	public GameObject gameController;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape) && !((checkOngoing)gameController.GetComponent(typeof(checkOngoing))).onGoing)
		{
			Time.timeScale = 0f;
			AudioListener.pause = true;
			quitGameMenu.SetActive(true);
			slendrina.SetActive(false);
			Cursor.visible = true;
			Screen.lockCursor = false;
			playerScript.GetComponent<FPSInputController>().enabled = false;
			playerScript.GetComponent<MouseLook>().enabled = false;
			mouseLook.GetComponent<MouseLook>().enabled = false;
			((Footsteps)playerScript.GetComponent(typeof(Footsteps))).GetComponent<AudioSource>().Stop();
			animationHolder.GetComponent<Animation>().Stop("HeadBobAnimation");
			animationHolder.GetComponent<Animation>().Play("playerIdle");
			((SensitivitySlider)mouseLook.GetComponent(typeof(SensitivitySlider))).enabled = true;
		}
	}

	public virtual void Main()
	{
	}
}
