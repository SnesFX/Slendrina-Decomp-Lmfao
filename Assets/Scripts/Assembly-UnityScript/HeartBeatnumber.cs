using System;
using UnityEngine;

[Serializable]
public class HeartBeatnumber : MonoBehaviour
{
	public GUIText heartBeatText;

	public int heartBeat;

	public HeartBeatnumber()
	{
		heartBeat = 75;
	}

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		heartBeatText.text = string.Empty + heartBeat;
		if (heartBeat < 75)
		{
			heartBeat = 75;
		}
	}

	public virtual void Main()
	{
	}
}
