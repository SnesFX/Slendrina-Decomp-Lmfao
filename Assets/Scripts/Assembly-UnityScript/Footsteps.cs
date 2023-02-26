using System;
using UnityEngine;

[Serializable]
public class Footsteps : MonoBehaviour
{
	public AudioClip footstepGrass;

	public AudioClip footstepWood;

	public AudioClip footstepConcrete;

	public float walkAudioSpeed;

	private float walkAudioTimer;

	public bool isWalking;

	public bool grassWalk;

	public bool woodWalk;

	public bool concreteWalk;

	public GameObject animationHolder;

	public bool walkingSand;

	public bool walkingTrappa;

	public Footsteps()
	{
		walkAudioSpeed = 0.4f;
		isWalking = true;
	}

	public virtual void Start()
	{
		AudioSource component = GetComponent<AudioSource>();
	}

	public virtual void Update()
	{
	}

	public virtual void walk()
	{
		isWalking = true;
		if (grassWalk)
		{
			walkingTrappa = false;
			if (!walkingSand)
			{
				GetComponent<AudioSource>().clip = footstepGrass;
				GetComponent<AudioSource>().Play();
				walkingSand = true;
			}
		}
		else if (concreteWalk)
		{
			walkingSand = false;
			if (!walkingTrappa)
			{
				GetComponent<AudioSource>().clip = footstepConcrete;
				GetComponent<AudioSource>().Play();
				walkingTrappa = true;
			}
		}
	}

	public virtual void stopwalk()
	{
		walkingSand = false;
		walkingTrappa = false;
		isWalking = false;
		GetComponent<AudioSource>().Stop();
	}

	public virtual void OnControllerColliderHit(ControllerColliderHit collision)
	{
		if (collision.collider.gameObject.name == "House")
		{
			woodWalk = true;
			grassWalk = false;
			concreteWalk = false;
		}
		else if (collision.collider.gameObject.name == "Terrain")
		{
			grassWalk = true;
			woodWalk = false;
			concreteWalk = false;
		}
		else if (collision.collider.gameObject.name == "Trappa")
		{
			concreteWalk = true;
			woodWalk = false;
			grassWalk = false;
		}
	}

	public virtual void Main()
	{
	}
}
