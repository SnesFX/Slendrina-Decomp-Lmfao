using UnityEngine;

public class AdBuddizBinding
{
	public enum ABLogLevel
	{
		Info = 0,
		Error = 1,
		Silent = 2
	}

	static AdBuddizBinding()
	{
	}

	public static void SetLogLevel(ABLogLevel level)
	{
		if (Application.platform != RuntimePlatform.Android && Application.platform != RuntimePlatform.IPhonePlayer)
		{
		}
	}

	public static void SetAndroidPublisherKey(string publisherKey)
	{
		if (Application.platform != RuntimePlatform.Android)
		{
		}
	}

	public static void SetIOSPublisherKey(string publisherKey)
	{
		if (Application.platform != RuntimePlatform.IPhonePlayer)
		{
		}
	}

	public static void SetTestModeActive()
	{
		if (Application.platform != RuntimePlatform.Android && Application.platform != RuntimePlatform.IPhonePlayer)
		{
		}
	}

	public static void CacheAds()
	{
		if (Application.platform != RuntimePlatform.Android && Application.platform != RuntimePlatform.IPhonePlayer)
		{
		}
	}

	public static bool IsReadyToShowAd()
	{
		if (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer)
		{
		}
		return false;
	}

	public static bool IsReadyToShowAd(string placementId)
	{
		if (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer)
		{
		}
		return false;
	}

	public static void ShowAd()
	{
		if (Application.platform != RuntimePlatform.Android && Application.platform != RuntimePlatform.IPhonePlayer)
		{
		}
	}

	public static void ShowAd(string placementId)
	{
		if (Application.platform != RuntimePlatform.Android && Application.platform != RuntimePlatform.IPhonePlayer)
		{
		}
	}

	public static void LogNative(string text)
	{
		if (Application.platform != RuntimePlatform.Android && Application.platform != RuntimePlatform.IPhonePlayer)
		{
		}
	}
}
