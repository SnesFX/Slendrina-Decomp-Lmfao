using System;
using UnityEngine;

[Serializable]
public class PlayerClampToWorld : MonoBehaviour
{
	public float worldsizeMinX;

	public float worldsizeMaxX;

	public float worldsizeMinZ;

	public float worldsizeMaxZ;

	public float edgeOfWorldBuffer;

	private Transform myTransform;

	public PlayerClampToWorld()
	{
		worldsizeMaxX = 512f;
		worldsizeMaxZ = 512f;
		edgeOfWorldBuffer = 10f;
	}

	public virtual void Start()
	{
		myTransform = transform;
	}

	public virtual void Update()
	{
		float x = Mathf.Clamp(myTransform.position.x, worldsizeMinX + edgeOfWorldBuffer, worldsizeMaxX - edgeOfWorldBuffer);
		Vector3 position = myTransform.position;
		float num = (position.x = x);
		Vector3 vector2 = (myTransform.position = position);
		float z = Mathf.Clamp(myTransform.position.z, worldsizeMinZ + edgeOfWorldBuffer, worldsizeMaxZ - edgeOfWorldBuffer);
		Vector3 position2 = myTransform.position;
		float num2 = (position2.z = z);
		Vector3 vector4 = (myTransform.position = position2);
	}

	public virtual void Main()
	{
	}
}
