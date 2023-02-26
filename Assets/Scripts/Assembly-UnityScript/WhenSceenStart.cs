using System;
using UnityEngine;

[Serializable]
public class WhenSceenStart : MonoBehaviour
{
	public GameObject difficultyHolder;

	public GameObject slendrina;

	public GameObject sensitivityHolder;

	public GameObject cameraRotate;

	public virtual void Start()
	{
		Cursor.visible = false;
		Screen.lockCursor = true;
		AudioListener.pause = false;
		if (BetweenScenesValues.difficultyEasy)
		{
			((NPCMovement)slendrina.GetComponent(typeof(NPCMovement))).killTimeShortDist = 40f;
			((NPCMovement)slendrina.GetComponent(typeof(NPCMovement))).killTimeLongDist = 20f;
			Debug.Log("EASY");
		}
		else if (BetweenScenesValues.difficultyMedium)
		{
			((NPCMovement)slendrina.GetComponent(typeof(NPCMovement))).killTimeShortDist = 80f;
			((NPCMovement)slendrina.GetComponent(typeof(NPCMovement))).killTimeLongDist = 40f;
			Debug.Log("MEDIUM");
		}
		else if (BetweenScenesValues.difficultyHard)
		{
			((NPCMovement)slendrina.GetComponent(typeof(NPCMovement))).killTimeShortDist = 150f;
			((NPCMovement)slendrina.GetComponent(typeof(NPCMovement))).killTimeLongDist = 75f;
			Debug.Log("HARD");
		}
		GameObject gameObject = GameObject.Find("Player");
		MouseLook mouseLook = (MouseLook)gameObject.GetComponent(typeof(MouseLook));
		GameObject gameObject2 = GameObject.Find("Main Camera");
		MouseLook mouseLook2 = (MouseLook)gameObject2.GetComponent(typeof(MouseLook));
		if (SaveSensitivityData.sliderValue > 5f || !(SaveSensitivityData.sliderValue >= 5f))
		{
			mouseLook.sensitivityX = SaveSensitivityData.sliderValue;
			mouseLook2.sensitivityY = SaveSensitivityData.sliderValue;
		}
		else
		{
			mouseLook.sensitivityX = 5f;
			mouseLook2.sensitivityY = 5f;
		}
	}

	public virtual void Update()
	{
		int num = 0;
		Quaternion localRotation = cameraRotate.transform.localRotation;
		float num2 = (localRotation.y = num);
		Quaternion quaternion2 = (cameraRotate.transform.localRotation = localRotation);
		int num3 = 0;
		Quaternion localRotation2 = cameraRotate.transform.localRotation;
		float num4 = (localRotation2.z = num3);
		Quaternion quaternion4 = (cameraRotate.transform.localRotation = localRotation2);
	}

	public virtual void Main()
	{
	}
}
