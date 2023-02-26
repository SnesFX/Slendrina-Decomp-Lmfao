using System;
using UnityEngine;

[Serializable]
public class FootStepScript2 : MonoBehaviour
{
	public float AudioTimer;

	public AudioClip FootStepGrass;

	public AudioClip FootStepWood;

	public AudioClip SwimmingSound;

	public AudioClip FootStepConcrete;

	public bool IslandfootGrounded;

	public bool WoodfootGrounded;

	public bool ConcretefootGrounded;

	public virtual void Update()
	{
		if (Input.GetKeyUp("w"))
		{
		}
		if (Input.GetKeyUp("s"))
		{
		}
		if (Input.GetKeyUp("a"))
		{
		}
		if (Input.GetKeyUp("d"))
		{
		}
		if (Input.GetKeyDown("space"))
		{
			GetComponent<AudioSource>().Pause();
			AudioTimer = 0f;
		}
		if (!(AudioTimer <= 0f))
		{
			AudioTimer -= Time.deltaTime;
		}
		if (!(AudioTimer >= 0f))
		{
			AudioTimer = 0f;
		}
	}

	public virtual void OnControllerColliderHit(ControllerColliderHit col)
	{
		if (col.gameObject.CompareTag("Island") && Input.GetAxis("Vertical") != 0f && AudioTimer == 0f)
		{
			IslandfootGrounded = true;
			GetComponent<AudioSource>().clip = FootStepGrass;
			GetComponent<AudioSource>().PlayOneShot(FootStepGrass);
			AudioTimer = 0.9f;
			WoodfootGrounded = false;
			ConcretefootGrounded = false;
		}
		if (col.gameObject.CompareTag("Island") && Input.GetAxis("Horizontal") != 0f && AudioTimer == 0f)
		{
			GetComponent<AudioSource>().clip = FootStepGrass;
			GetComponent<AudioSource>().PlayOneShot(FootStepGrass);
			AudioTimer = 0.9f;
		}
		if (col.gameObject.CompareTag("golv") && Input.GetAxis("Vertical") != 0f && AudioTimer == 0f)
		{
			WoodfootGrounded = true;
			GetComponent<AudioSource>().clip = FootStepWood;
			GetComponent<AudioSource>().PlayOneShot(FootStepWood);
			AudioTimer = 0.8f;
			IslandfootGrounded = false;
			ConcretefootGrounded = false;
		}
		if (col.gameObject.CompareTag("golv") && Input.GetAxis("Horizontal") != 0f && AudioTimer == 0f)
		{
			GetComponent<AudioSource>().clip = FootStepWood;
			GetComponent<AudioSource>().PlayOneShot(FootStepWood);
			AudioTimer = 0.8f;
		}
		if (col.gameObject.CompareTag("havsbotten") && Input.GetAxis("Vertical") != 0f && AudioTimer == 0f)
		{
			GetComponent<AudioSource>().clip = SwimmingSound;
			GetComponent<AudioSource>().PlayOneShot(SwimmingSound);
			AudioTimer = 1.2f;
		}
		if (col.gameObject.CompareTag("havsbotten") && Input.GetAxis("Horizontal") != 0f && AudioTimer == 0f)
		{
			GetComponent<AudioSource>().clip = SwimmingSound;
			GetComponent<AudioSource>().PlayOneShot(SwimmingSound);
			AudioTimer = 1.2f;
		}
		if (col.gameObject.CompareTag("concrete") && Input.GetAxis("Vertical") != 0f && AudioTimer == 0f)
		{
			ConcretefootGrounded = true;
			GetComponent<AudioSource>().clip = FootStepConcrete;
			GetComponent<AudioSource>().PlayOneShot(FootStepConcrete);
			AudioTimer = 0.9f;
			WoodfootGrounded = false;
			IslandfootGrounded = false;
		}
		if (col.gameObject.CompareTag("concrete") && Input.GetAxis("Horizontal") != 0f && AudioTimer == 0f)
		{
			GetComponent<AudioSource>().clip = FootStepConcrete;
			GetComponent<AudioSource>().PlayOneShot(FootStepConcrete);
			AudioTimer = 0.9f;
		}
	}

	public virtual void Main()
	{
	}
}
