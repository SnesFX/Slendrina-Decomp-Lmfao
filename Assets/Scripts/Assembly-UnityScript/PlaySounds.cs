using System;
using UnityEngine;

[Serializable]
public class PlaySounds : MonoBehaviour
{
	public AudioClip seeSound;

	public AudioClip screamSound;

	public AudioClip walkSound;

	public AudioClip flicker;

	public AudioClip faceSee;

	public AudioClip lightSwitch;

	public AudioClip tavlaHead;

	public AudioClip doorSlam;

	public AudioClip faceScreen;

	public AudioClip standSlendrina;

	public AudioClip scareFace;

	public AudioClip scaryBang;

	public AudioClip slendrinaHeadGarderob;

	public AudioClip flyingHink;

	public AudioClip slendrinaBreath;

	public AudioClip boomSound;

	public virtual void Start()
	{
	}

	public virtual void inDoor()
	{
		AudioSource.PlayClipAtPoint(seeSound, transform.position);
	}

	public virtual void slendrinaScream()
	{
		AudioSource.PlayClipAtPoint(screamSound, transform.position);
	}

	public virtual void slendrinaWalk()
	{
		AudioSource.PlayClipAtPoint(walkSound, transform.position);
	}

	public virtual void flickerLight()
	{
		AudioSource.PlayClipAtPoint(flicker, transform.position);
	}

	public virtual void slendrinaFace()
	{
		AudioSource.PlayClipAtPoint(faceSee, transform.position);
	}

	public virtual void lightButton()
	{
		AudioSource.PlayClipAtPoint(lightSwitch, transform.position);
	}

	public virtual void headTavla()
	{
		AudioSource.PlayClipAtPoint(tavlaHead, transform.position);
	}

	public virtual void slamDoor()
	{
		AudioSource.PlayClipAtPoint(doorSlam, transform.position);
	}

	public virtual void screenFace()
	{
		AudioSource.PlayClipAtPoint(faceScreen, transform.position);
	}

	public virtual void slendrinaStand()
	{
		AudioSource.PlayClipAtPoint(standSlendrina, transform.position);
	}

	public virtual void faceScare()
	{
		AudioSource.PlayClipAtPoint(scareFace, transform.position);
	}

	public virtual void bangLjud()
	{
		AudioSource.PlayClipAtPoint(scaryBang, transform.position);
	}

	public virtual void HeadGarde()
	{
		AudioSource.PlayClipAtPoint(slendrinaHeadGarderob, transform.position);
	}

	public virtual void FlyingHink()
	{
		AudioSource.PlayClipAtPoint(flyingHink, transform.position);
	}

	public virtual void SlendrinaBreath()
	{
		AudioSource.PlayClipAtPoint(slendrinaBreath, transform.position);
	}

	public virtual void BoomSound()
	{
		AudioSource.PlayClipAtPoint(boomSound, transform.position);
	}

	public virtual void Main()
	{
	}
}
