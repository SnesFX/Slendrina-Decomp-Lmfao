using UnityEngine;

public class StartTheApp : MonoBehaviour
{
	public void Awake()
	{
		Debug.Log("Redo");
		AdColony.OnVideoFinished = OnVideoFinished;
		AdColony.Configure("version:1.0,store:google", "app5648e9eeaa2f438486", "vz7dd995d264d34ea298");
	}

	public void PlayAVideo()
	{
		Debug.Log("Ska spela");
		if (AdColony.IsVideoAvailable("vz7dd995d264d34ea298"))
		{
			Debug.Log("Play AdColony Video");
			AdColony.ShowVideoAd("vz7dd995d264d34ea298");
		}
		else
		{
			Debug.Log("Video Not Available");
		}
	}

	private void OnVideoFinished(bool ad_was_shown)
	{
		Debug.Log("On Video Finished");
	}
}
