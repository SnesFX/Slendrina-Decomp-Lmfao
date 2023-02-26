using System;
using UnityEngine;

public class UnityAdsHelper : MonoBehaviour
{
	public string iosGameID;

	public string androidGameID = "131623585";

	public bool enableTestMode = true;

	public bool showInfoLogs;

	public bool showDebugLogs;

	public bool showWarningLogs = true;

	public bool showErrorLogs = true;

	private static Action _handleFinished;

	private static Action _handleSkipped;

	private static Action _handleFailed;

	private static Action _onContinue;

	public static bool isShowing
	{
		get
		{
			return false;
		}
	}

	public static bool isSupported
	{
		get
		{
			return false;
		}
	}

	public static bool isInitialized
	{
		get
		{
			return false;
		}
	}

	private void Start()
	{
		Debug.LogWarning("Unity Ads is not supported under the current build platform.");
	}

	public static bool IsReady()
	{
		return false;
	}

	public static bool IsReady(string zoneID)
	{
		return false;
	}

	public static void ShowAd()
	{
		Debug.LogError("Failed to show ad. Unity Ads is not supported under the current build platform.");
	}

	public static void ShowAd(string zoneID)
	{
		ShowAd();
	}

	public static void ShowAd(string zoneID, Action handleFinished)
	{
		ShowAd();
	}

	public static void ShowAd(string zoneID, Action handleFinished, Action handleSkipped)
	{
		ShowAd();
	}

	public static void ShowAd(string zoneID, Action handleFinished, Action handleSkipped, Action handleFailed)
	{
		ShowAd();
	}

	public static void ShowAd(string zoneID, Action handleFinished, Action handleSkipped, Action handleFailed, Action onContinue)
	{
		ShowAd();
	}
}
