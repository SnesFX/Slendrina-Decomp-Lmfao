using System;
using Boo.Lang.Runtime;
using UnityEngine;

[Serializable]
public class SensitivityController : MonoBehaviour
{
	public GameObject sensitivityData;

	[NonSerialized]
	public static float counter;

	public GameObject pricken;

	public GameObject rotateArea;

	public virtual void Update()
	{
		if (counter == 1f)
		{
			float x = 0.33f;
			Vector3 position = pricken.transform.position;
			float num = (position.x = x);
			Vector3 vector2 = (pricken.transform.position = position);
			RuntimeServices.SetProperty((SaveSensitivityData)sensitivityData.GetComponent(typeof(SaveSensitivityData)), "number", 1);
			((SwipeScript)rotateArea.GetComponent(typeof(SwipeScript))).speed = 5f;
			((SwipeScript)rotateArea.GetComponent(typeof(SwipeScript))).speedPitch = 5f;
		}
		else if (counter == 2f)
		{
			float x2 = 0.382f;
			Vector3 position2 = pricken.transform.position;
			float num2 = (position2.x = x2);
			Vector3 vector4 = (pricken.transform.position = position2);
			RuntimeServices.SetProperty((SaveSensitivityData)sensitivityData.GetComponent(typeof(SaveSensitivityData)), "number", 2);
			((SwipeScript)rotateArea.GetComponent(typeof(SwipeScript))).speed = 8f;
			((SwipeScript)rotateArea.GetComponent(typeof(SwipeScript))).speedPitch = 4f;
		}
		else if (counter == 3f)
		{
			float x3 = 0.439f;
			Vector3 position3 = pricken.transform.position;
			float num3 = (position3.x = x3);
			Vector3 vector6 = (pricken.transform.position = position3);
			RuntimeServices.SetProperty((SaveSensitivityData)sensitivityData.GetComponent(typeof(SaveSensitivityData)), "number", 3);
			((SwipeScript)rotateArea.GetComponent(typeof(SwipeScript))).speed = 13f;
			((SwipeScript)rotateArea.GetComponent(typeof(SwipeScript))).speedPitch = 7f;
		}
		else if (counter == 4f)
		{
			float x4 = 0.498f;
			Vector3 position4 = pricken.transform.position;
			float num4 = (position4.x = x4);
			Vector3 vector8 = (pricken.transform.position = position4);
			RuntimeServices.SetProperty((SaveSensitivityData)sensitivityData.GetComponent(typeof(SaveSensitivityData)), "number", 4);
			((SwipeScript)rotateArea.GetComponent(typeof(SwipeScript))).speed = 18f;
			((SwipeScript)rotateArea.GetComponent(typeof(SwipeScript))).speedPitch = 9f;
		}
		else if (counter == 5f)
		{
			float x5 = 0.55f;
			Vector3 position5 = pricken.transform.position;
			float num5 = (position5.x = x5);
			Vector3 vector10 = (pricken.transform.position = position5);
			RuntimeServices.SetProperty((SaveSensitivityData)sensitivityData.GetComponent(typeof(SaveSensitivityData)), "number", 5);
			((SwipeScript)rotateArea.GetComponent(typeof(SwipeScript))).speed = 30f;
			((SwipeScript)rotateArea.GetComponent(typeof(SwipeScript))).speedPitch = 15f;
		}
		else if (counter == 6f)
		{
			float x6 = 0.61f;
			Vector3 position6 = pricken.transform.position;
			float num6 = (position6.x = x6);
			Vector3 vector12 = (pricken.transform.position = position6);
			RuntimeServices.SetProperty((SaveSensitivityData)sensitivityData.GetComponent(typeof(SaveSensitivityData)), "number", 6);
			((SwipeScript)rotateArea.GetComponent(typeof(SwipeScript))).speed = 45f;
			((SwipeScript)rotateArea.GetComponent(typeof(SwipeScript))).speedPitch = 23f;
		}
		else if (counter == 7f)
		{
			float x7 = 0.668f;
			Vector3 position7 = pricken.transform.position;
			float num7 = (position7.x = x7);
			Vector3 vector14 = (pricken.transform.position = position7);
			RuntimeServices.SetProperty((SaveSensitivityData)sensitivityData.GetComponent(typeof(SaveSensitivityData)), "number", 7);
			((SwipeScript)rotateArea.GetComponent(typeof(SwipeScript))).speed = 60f;
			((SwipeScript)rotateArea.GetComponent(typeof(SwipeScript))).speedPitch = 30f;
		}
	}

	public virtual void CountUp()
	{
		if (counter != 7f)
		{
			counter += 1f;
		}
	}

	public virtual void CountDown()
	{
		if (counter != 1f)
		{
			counter -= 1f;
		}
	}

	public virtual void Main()
	{
	}
}
