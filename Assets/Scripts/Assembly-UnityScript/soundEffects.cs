using System;
using UnityEngine;

[Serializable]
public class soundEffects : MonoBehaviour
{
	public AudioClip headDoor;

	public AudioClip SlendrinaGlider;

	public AudioClip BangLjud;

	public AudioClip FlickerLight;

	public AudioClip LightButton;

	public AudioClip slendrinaBreath;

	public AudioClip SlendrinaFace;

	public AudioClip boomSound;

	public AudioClip FlashlightButton;

	public AudioClip SlendrinaScream;

	public AudioClip flyingHink;

	public AudioClip headGarde;

	public AudioClip SlendrinaStand;

	public AudioClip buttonOver;

	public AudioClip clickButton;

	public AudioClip doorSlam;

	public AudioClip slendrinaTavla;

	public AudioClip faceScreen;

	public virtual void Start()
	{
	}

	public virtual void slendrinaHeadDoor()
	{
		AudioSource.PlayClipAtPoint(headDoor, transform.position);
	}

	public virtual void slendrinaWalk()
	{
		AudioSource.PlayClipAtPoint(SlendrinaGlider, transform.position);
	}

	public virtual void bangLjud()
	{
		AudioSource.PlayClipAtPoint(BangLjud, transform.position);
	}

	public virtual void flickerLight()
	{
		AudioSource.PlayClipAtPoint(FlickerLight, transform.position);
	}

	public virtual void lightButton()
	{
		AudioSource.PlayClipAtPoint(LightButton, transform.position);
	}

	public virtual void SlendrinaBreath()
	{
		AudioSource.PlayClipAtPoint(slendrinaBreath, transform.position);
	}

	public virtual void slendrinaFace()
	{
		AudioSource.PlayClipAtPoint(SlendrinaFace, transform.position);
	}

	public virtual void BoomSound()
	{
		AudioSource.PlayClipAtPoint(boomSound, transform.position);
	}

	public virtual void flashlightButton()
	{
		AudioSource.PlayClipAtPoint(FlashlightButton, transform.position);
	}

	public virtual void slendrinaScream()
	{
		AudioSource.PlayClipAtPoint(SlendrinaScream, transform.position);
	}

	public virtual void FlyingHink()
	{
		AudioSource.PlayClipAtPoint(flyingHink, transform.position);
	}

	public virtual void HeadGarde()
	{
		AudioSource.PlayClipAtPoint(headGarde, transform.position);
	}

	public virtual void slendrinaStand()
	{
		AudioSource.PlayClipAtPoint(SlendrinaStand, transform.position);
	}

	public virtual void overButton()
	{
		AudioSource.PlayClipAtPoint(buttonOver, transform.position);
	}

	public virtual void buttonClick()
	{
		AudioSource.PlayClipAtPoint(clickButton, transform.position);
	}

	public virtual void slamDoor()
	{
		AudioSource.PlayClipAtPoint(doorSlam, transform.position);
	}

	public virtual void tavla()
	{
		AudioSource.PlayClipAtPoint(slendrinaTavla, transform.position);
	}

	public virtual void screenFace()
	{
		AudioSource.PlayClipAtPoint(faceScreen, transform.position);
	}

	public virtual void Main()
	{
	}
}
