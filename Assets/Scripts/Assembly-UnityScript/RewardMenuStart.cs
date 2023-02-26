using System;
using UnityEngine;

[Serializable]
public class RewardMenuStart : MonoBehaviour
{
	public int total;

	public int rewPoints;

	public GUIText stcPoints;

	public virtual void OnEnable()
	{
		Debug.Log("reward Again");
		total = PlayerPrefs.GetInt("stcPoints") + rewPoints;
		PlayerPrefs.SetInt("stcPoints", total);
		stcPoints.GetComponent<GUIText>().text = PlayerPrefs.GetInt("stcPoints").ToString();
	}

	public virtual void Update()
	{
	}

	public virtual void Main()
	{
	}
}
