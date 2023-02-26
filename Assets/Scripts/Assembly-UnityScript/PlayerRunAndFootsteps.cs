using System;
using UnityEngine;

[Serializable]
[RequireComponent(typeof(AudioSource))]
public class PlayerRunAndFootsteps : MonoBehaviour
{
	public AudioClip[] walkSounds;

	public AudioClip[] runSounds;

	public float walkAudioSpeed;

	public float runAudioSpeed;

	private float walkAudioTimer;

	private float runAudioTimer;

	public bool isWalking;

	public bool isRunning;

	public float walkSpeed;

	public float runSpeed;

	private CharacterController chCtrl;

	public PlayerRunAndFootsteps()
	{
		walkAudioSpeed = 0.4f;
		runAudioSpeed = 0.2f;
		walkSpeed = 8f;
		runSpeed = 20f;
	}

	public virtual void Start()
	{
		chCtrl = (CharacterController)GetComponent(typeof(CharacterController));
	}

	public virtual void Update()
	{
		SetSpeed();
		if (chCtrl.isGrounded)
		{
			PlayFootsteps();
			return;
		}
		walkAudioTimer = 1000f;
		runAudioTimer = 1000f;
	}

	public virtual void SetSpeed()
	{
		float num = walkSpeed;
		if ((chCtrl.isGrounded && Input.GetKey("left shift")) || Input.GetKey("right shift"))
		{
			num = runSpeed;
		}
	}

	public virtual void PlayFootsteps()
	{
		if (Input.GetAxis("Horizontal") != 0f || Input.GetAxis("Vertical") != 0f)
		{
			if (Input.GetKey("left shift") || Input.GetKey("right shift"))
			{
				isWalking = false;
				isRunning = true;
			}
			else
			{
				isWalking = true;
				isRunning = false;
			}
		}
		else
		{
			isWalking = false;
			isRunning = false;
		}
		if (isWalking)
		{
			if (!(walkAudioTimer <= walkAudioSpeed))
			{
				GetComponent<AudioSource>().Stop();
				GetComponent<AudioSource>().clip = walkSounds[UnityEngine.Random.Range(0, walkSounds.Length)];
				GetComponent<AudioSource>().Play();
				walkAudioTimer = 0f;
			}
		}
		else if (isRunning)
		{
			if (!(runAudioTimer <= runAudioSpeed))
			{
				GetComponent<AudioSource>().Stop();
				GetComponent<AudioSource>().clip = runSounds[UnityEngine.Random.Range(0, runSounds.Length)];
				GetComponent<AudioSource>().Play();
				runAudioTimer = 0f;
			}
		}
		else
		{
			GetComponent<AudioSource>().Stop();
		}
		walkAudioTimer += Time.deltaTime;
		runAudioTimer += Time.deltaTime;
	}

	public virtual void Main()
	{
	}
}
