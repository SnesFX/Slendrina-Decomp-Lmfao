using System;
using UnityEngine;

[Serializable]
public class TextSizeHolder : MonoBehaviour
{
	public int fontSize;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		GetComponent<GUIText>().fontSize = Mathf.Min(Mathf.FloorToInt(Screen.width * fontSize / 1000), Mathf.FloorToInt(Screen.height * fontSize / 1000));
	}

	public virtual void Main()
	{
	}
}
