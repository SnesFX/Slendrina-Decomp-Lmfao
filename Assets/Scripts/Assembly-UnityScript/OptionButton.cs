using System;
using Boo.Lang.Runtime;
using UnityEngine;
using UnityScript.Lang;

[Serializable]
public class OptionButton : MonoBehaviour
{
	public GameObject optionMenu;

	public GameObject sensitivityData;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		int i = 0;
		Touch[] touches = Input.touches;
		for (int length = touches.Length; i < length; i++)
		{
			if (touches[i].phase == TouchPhase.Ended && GetComponent<GUITexture>().HitTest(touches[i].position))
			{
				if (RuntimeServices.EqualityOperator(UnityRuntimeServices.GetProperty((SaveSensitivityData)sensitivityData.GetComponent(typeof(SaveSensitivityData)), "number"), 1))
				{
					SensitivityController.counter = 1f;
				}
				else if (RuntimeServices.EqualityOperator(UnityRuntimeServices.GetProperty((SaveSensitivityData)sensitivityData.GetComponent(typeof(SaveSensitivityData)), "number"), 2))
				{
					SensitivityController.counter = 2f;
				}
				else if (RuntimeServices.EqualityOperator(UnityRuntimeServices.GetProperty((SaveSensitivityData)sensitivityData.GetComponent(typeof(SaveSensitivityData)), "number"), 3))
				{
					SensitivityController.counter = 3f;
				}
				else if (RuntimeServices.EqualityOperator(UnityRuntimeServices.GetProperty((SaveSensitivityData)sensitivityData.GetComponent(typeof(SaveSensitivityData)), "number"), 4))
				{
					SensitivityController.counter = 4f;
				}
				else if (RuntimeServices.EqualityOperator(UnityRuntimeServices.GetProperty((SaveSensitivityData)sensitivityData.GetComponent(typeof(SaveSensitivityData)), "number"), 5))
				{
					SensitivityController.counter = 5f;
				}
				else if (RuntimeServices.EqualityOperator(UnityRuntimeServices.GetProperty((SaveSensitivityData)sensitivityData.GetComponent(typeof(SaveSensitivityData)), "number"), 6))
				{
					SensitivityController.counter = 6f;
				}
				else if (RuntimeServices.EqualityOperator(UnityRuntimeServices.GetProperty((SaveSensitivityData)sensitivityData.GetComponent(typeof(SaveSensitivityData)), "number"), 7))
				{
					SensitivityController.counter = 7f;
				}
				else if (RuntimeServices.EqualityOperator(UnityRuntimeServices.GetProperty((SaveSensitivityData)sensitivityData.GetComponent(typeof(SaveSensitivityData)), "number"), 0))
				{
					SensitivityController.counter = 4f;
				}
				Time.timeScale = 0f;
				optionMenu.SetActive(true);
			}
		}
	}

	public virtual void Main()
	{
	}
}
