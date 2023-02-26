using UnityEngine;

public class AdColony : MonoBehaviour
{
	public delegate void VideoStartedDelegate();

	public delegate void VideoFinishedDelegate(bool ad_shown);

	public delegate void VideoFinishedWithInfoDelegate(AdColonyAd ad_shown);

	public delegate void V4VCResultDelegate(bool success, string name, int amount);

	public delegate void AdAvailabilityChangeDelegate(bool available, string zone_id);

	private static AdColony instance;

	public static string version = "2.1.2.1";

	public static VideoStartedDelegate OnVideoStarted;

	public static VideoFinishedDelegate OnVideoFinished;

	public static VideoFinishedWithInfoDelegate OnVideoFinishedWithInfo;

	public static V4VCResultDelegate OnV4VCResult;

	public static AdAvailabilityChangeDelegate OnAdAvailabilityChange;

	private static bool configured;

	private bool was_paused;

	private static void ensureInstance()
	{
		if (instance == null)
		{
			Debug.LogWarning("AdColony Unity version -- " + version);
			instance = Object.FindObjectOfType(typeof(AdColony)) as AdColony;
			if (instance == null)
			{
				instance = new GameObject("AdColony").AddComponent<AdColony>();
			}
		}
	}

	private void Awake()
	{
		base.name = "AdColony";
		Object.DontDestroyOnLoad(base.transform.gameObject);
	}

	private void OnApplicationPause()
	{
		was_paused = true;
	}

	private void Update()
	{
		if (was_paused)
		{
			was_paused = false;
		}
	}

	public void OnAdColonyVideoStarted(string args)
	{
		if (OnVideoStarted != null)
		{
			OnVideoStarted();
		}
	}

	public void OnAdColonyVideoFinished(string args)
	{
		string[] array = args.Split('|');
		if (OnVideoFinished != null)
		{
			OnVideoFinished(array[0].Equals("true"));
		}
		if (OnVideoFinishedWithInfo != null)
		{
			OnVideoFinishedWithInfo(new AdColonyAd(array));
		}
	}

	public void OnAdColonyV4VCResult(string args)
	{
		if (OnV4VCResult != null)
		{
			string[] array = args.Split('|');
			bool success = array[0].Equals("true");
			int amount = int.Parse(array[1]);
			string text = array[2];
			OnV4VCResult(success, text, amount);
		}
	}

	public void OnAdColonyAdAvailabilityChange(string args)
	{
		if (OnAdAvailabilityChange != null)
		{
			string[] array = args.Split('|');
			OnAdAvailabilityChange(array[0].Equals("true"), array[1]);
		}
	}

	public static void Configure(string app_version, string app_id, params string[] zone_ids)
	{
		if (!configured)
		{
			ensureInstance();
			Debug.LogWarning("AdColony has been stubbed out.");
			configured = true;
		}
	}

	public static void SetCustomID(string custom_id)
	{
	}

	public static string GetCustomID()
	{
		return "undefined";
	}

	public static bool IsVideoAvailable()
	{
		return false;
	}

	public static bool IsVideoAvailable(string zone_id)
	{
		return false;
	}

	public static bool IsV4VCAvailable()
	{
		return false;
	}

	public static bool IsV4VCAvailable(string zone_id)
	{
		return false;
	}

	public static string GetDeviceID()
	{
		return "undefined";
	}

	public static string GetOpenUDID()
	{
		return "undefined";
	}

	public static string GetODIN1()
	{
		return "undefined";
	}

	public static int GetV4VCAmount()
	{
		return 0;
	}

	public static int GetV4VCAmount(string zone_id)
	{
		return 0;
	}

	public static string GetV4VCName()
	{
		return "undefined";
	}

	public static string GetV4VCName(string zone_id)
	{
		return "undefined";
	}

	public static bool ShowVideoAd()
	{
		return false;
	}

	public static bool ShowVideoAd(string zone_id)
	{
		return false;
	}

	public static bool ShowV4VC(bool popup_result)
	{
		return false;
	}

	public static bool ShowV4VC(bool popup_result, string zone_id)
	{
		return false;
	}

	public static void OfferV4VC(bool popup_result)
	{
	}

	public static void OfferV4VC(bool popup_result, string zone_id)
	{
	}

	public static string StatusForZone(string zone_id)
	{
		return "undefined";
	}

	public static void NotifyIAPComplete(string product_id, string trans_id, string currency_code, double price, int quantity)
	{
	}
}
