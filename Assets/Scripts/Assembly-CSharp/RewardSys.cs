using UnityEngine;

public class RewardSys : MonoBehaviour
{
	public static bool rewardOnOff;

	public GameObject rewardMenu;

	public GameObject stcOkButton;

	public GameObject videoButton;

	private void Start()
	{
	}

	private void Update()
	{
		if (rewardOnOff)
		{
			Debug.Log("Hi there");
			rewardMenu.SetActive(true);
			stcOkButton.SetActive(false);
			videoButton.SetActive(false);
			rewardOnOff = false;
		}
	}
}
