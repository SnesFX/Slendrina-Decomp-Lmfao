using System;
using UnityEngine;

[Serializable]
[RequireComponent(typeof(Rigidbody))]
public class NPCMovement : MonoBehaviour
{
	private Transform myTransform;

	private Rigidbody myRigidbody;

	public Transform target;

	public Transform targetSeePoint;

	public Transform targetHightPoint;

	public Transform slendrinaEyes;

	public PlayerHealth playerHealthScript;

	public float moveSpeed;

	public float turnSpeed;

	public float rotateSpeed;

	private Vector3 desiredVelocity;

	public bool isGrounded;

	public float rayDistance;

	public float teleportPositionXmax;

	public float teleportPositionXmin;

	public float teleportPositionY;

	public float teleportPositionZmax;

	public float teleportPositionZmin;

	public NPC myState;

	public float minimumRange;

	public float middleRange;

	public float maximumRange;

	private float minimumRangeSqr;

	private float middleRangeSqr;

	private float maximumRangeSqr;

	public bool isNpcChasing;

	public float freeRoamTimer;

	public float freeRoamTimerMax;

	public float freeRoamTimerMaxRange;

	public float freeRoamTimerMaxAdjusted;

	private Vector3 calcDir;

	public bool isSlender;

	public bool isVisible;

	public bool slendrinaSeePlayer;

	public float offScreenDot;

	public AudioClip enemySightedSound;

	public AudioClip enemySightedSoundFar;

	private bool hasPlayedSeenSound;

	private bool hasPlayedSeenSoundFar;

	private float reduceDistanceAmount;

	public float increaseSpeedAmount;

	public float teleportRepeating;

	public float killTimeShortDist;

	public float killTimeLongDist;

	public Transform slendrinaRight;

	public Transform slendrinaLeft;

	public Transform playerRight;

	public Transform playerLeft;

	public bool playerFlashlightOff;

	public bool slendrinaSameY;

	public NPCMovement()
	{
		moveSpeed = 6f;
		turnSpeed = 2f;
		rotateSpeed = 2f;
		rayDistance = 20f;
		isNpcChasing = true;
		freeRoamTimerMax = 5f;
		freeRoamTimerMaxRange = 1.5f;
		freeRoamTimerMaxAdjusted = 5f;
		calcDir = Vector3.forward;
		isSlender = true;
		offScreenDot = 0.8f;
		increaseSpeedAmount = 0.2f;
	}

	public virtual void Start()
	{
		reduceDistanceAmount = (maximumRange - 4f) / 7f;
		myTransform = transform;
		myRigidbody = GetComponent<Rigidbody>();
		myRigidbody.freezeRotation = true;
		freeRoamTimer = 0f;
		if (isSlender)
		{
			InvokeRepeating("TeleportEnemy", 30f, teleportRepeating * 1.3f);
			Debug.Log("Allt OK!!");
			GameObject gameObject = GameObject.Find("Player");
			if ((bool)gameObject)
			{
				target = gameObject.transform;
				playerHealthScript = (PlayerHealth)target.GetComponent(typeof(PlayerHealth));
			}
			else
			{
				Debug.Log("no object named player was found");
			}
			if (!target)
			{
				Debug.LogWarning("No Target Object in the Inspector");
				target = GameObject.Find("Player").transform;
			}
			if (!playerHealthScript)
			{
				target.GetComponent(typeof(PlayerHealth));
			}
		}
		minimumRangeSqr = minimumRange * minimumRange;
		middleRangeSqr = middleRange * middleRange;
		maximumRangeSqr = maximumRange * maximumRange;
	}

	public virtual void Update()
	{
		Vector3 forward = target.position - transform.position;
		Quaternion to = Quaternion.LookRotation(forward);
		transform.rotation = Quaternion.RotateTowards(transform.rotation, to, Time.deltaTime * rotateSpeed);
		float y = myTransform.eulerAngles.y;
		transform.eulerAngles = new Vector3(0f, y, 0f);
		if (isSlender)
		{
			SlenderDecisions();
		}
		else
		{
			MakeSomeDecisions();
		}
		switch (myState)
		{
		case NPC.Idle:
		{
			Vector3 worldPosition = new Vector3(target.position.x, myTransform.position.y, target.position.z);
			myTransform.LookAt(worldPosition);
			desiredVelocity = new Vector3(0f, myRigidbody.velocity.y, 0f);
			break;
		}
		case NPC.FreeRoam:
			freeRoamTimer += Time.deltaTime;
			if (!(freeRoamTimer <= freeRoamTimerMaxAdjusted))
			{
				freeRoamTimer = 0f;
				freeRoamTimerMaxAdjusted = freeRoamTimerMax + UnityEngine.Random.Range(0f - freeRoamTimerMaxRange, freeRoamTimerMaxRange);
				calcDir = UnityEngine.Random.onUnitSphere;
				calcDir.y = 0f;
			}
			Moving(calcDir);
			break;
		case NPC.Chasing:
			Moving((target.position - myTransform.position).normalized);
			break;
		case NPC.RunningAway:
			Moving((myTransform.position - target.position).normalized);
			break;
		}
	}

	public virtual void FixedUpdate()
	{
		if (isGrounded)
		{
			myRigidbody.velocity = desiredVelocity;
		}
	}

	public virtual void MakeSomeDecisions()
	{
		float sqrMagnitude = (target.position - myTransform.position).sqrMagnitude;
		if (!(sqrMagnitude <= maximumRangeSqr))
		{
			if (isNpcChasing)
			{
				myState = NPC.Chasing;
			}
			else
			{
				myState = NPC.FreeRoam;
			}
		}
		else if (!(sqrMagnitude >= middleRangeSqr))
		{
			if (isNpcChasing)
			{
				myState = NPC.Chasing;
			}
			else
			{
				myState = NPC.FreeRoam;
			}
		}
		else if (!(sqrMagnitude >= minimumRangeSqr))
		{
			if (isNpcChasing)
			{
				myState = NPC.Idle;
			}
			else
			{
				myState = NPC.RunningAway;
			}
		}
		else if (isNpcChasing)
		{
			myState = NPC.Chasing;
		}
		else
		{
			myState = NPC.RunningAway;
		}
	}

	public virtual void TeleportEnemy()
	{
		CheckIfVisible();
		if (!slendrinaSeePlayer)
		{
			if (UnityEngine.Random.Range(0, 1) == 0)
			{
				int num = -1;
			}
			Vector3 origin = target.position + -1f * target.forward * minimumRange;
			origin.y = 0f;
			RaycastHit hitInfo = default(RaycastHit);
			if (Physics.Raycast(origin, -Vector3.up, out hitInfo, float.PositiveInfinity) && hitInfo.collider.gameObject.tag == "Terrain")
			{
				myTransform.position = hitInfo.point + new Vector3(0f, teleportPositionY, 0f);
				float y = targetHightPoint.position.y;
				Vector3 position = myTransform.position;
				float num2 = (position.y = y);
				Vector3 vector2 = (myTransform.position = position);
			}
		}
	}

	public virtual void SlenderDecisions()
	{
		CheckIfVisible();
		float sqrMagnitude = (target.position - myTransform.position).sqrMagnitude;
		if (isVisible)
		{
			RaycastHit hitInfo;
			if (!(sqrMagnitude <= maximumRangeSqr))
			{
				hitInfo = default(RaycastHit);
				if (Physics.Linecast(myTransform.position, target.position, out hitInfo))
				{
					Debug.DrawLine(myTransform.position, target.position, Color.green);
					if (hitInfo.collider.gameObject.name == target.name)
					{
						myState = NPC.Idle;
					}
				}
				playerHealthScript.HealthIncreaseBlood();
			}
			else if (!(sqrMagnitude > middleRangeSqr))
			{
				playerHealthScript = (PlayerHealth)target.GetComponent(typeof(PlayerHealth));
				if (!Physics.Linecast(slendrinaRight.position, target.position, out hitInfo))
				{
					return;
				}
				Debug.DrawLine(slendrinaRight.position, targetSeePoint.position, Color.red);
				if (hitInfo.collider.gameObject.name == target.name)
				{
					myState = NPC.Idle;
					if (!(sqrMagnitude >= middleRangeSqr))
					{
						playerHealthScript.faceGhost();
					}
					playerHealthScript.healthDecayRateBlood = killTimeShortDist;
					if (!playerFlashlightOff)
					{
						playerHealthScript.HealthDecreaseBlood();
						if (!hasPlayedSeenSound)
						{
							AudioSource.PlayClipAtPoint(enemySightedSound, target.position);
							playerHealthScript.faceGhost();
							hasPlayedSeenSound = true;
						}
					}
					playerHealthScript.faceGhost();
					slendrinaSeePlayer = true;
				}
				else if (Physics.Linecast(slendrinaLeft.position, target.position, out hitInfo))
				{
					Debug.DrawLine(slendrinaLeft.position, targetSeePoint.position, Color.red);
					if (hitInfo.collider.gameObject.name == target.name)
					{
						myState = NPC.Idle;
						if (!(sqrMagnitude >= middleRangeSqr))
						{
							playerHealthScript.faceGhost();
						}
						playerHealthScript.healthDecayRateBlood = killTimeShortDist;
						if (!playerFlashlightOff)
						{
							playerHealthScript.HealthDecreaseBlood();
							if (!hasPlayedSeenSound)
							{
								AudioSource.PlayClipAtPoint(enemySightedSound, target.position);
								playerHealthScript.faceGhost();
								hasPlayedSeenSound = true;
							}
						}
						playerHealthScript.faceGhost();
						slendrinaSeePlayer = true;
					}
					else
					{
						myState = NPC.Chasing;
						playerHealthScript.HealthIncreaseBlood();
						slendrinaSeePlayer = false;
					}
				}
				else
				{
					myState = NPC.Chasing;
					playerHealthScript.HealthIncreaseBlood();
				}
			}
			else
			{
				if (sqrMagnitude <= middleRangeSqr || sqrMagnitude >= maximumRangeSqr)
				{
					return;
				}
				playerHealthScript = (PlayerHealth)target.GetComponent(typeof(PlayerHealth));
				if (!Physics.Linecast(transform.position, target.position, out hitInfo))
				{
					return;
				}
				Debug.DrawLine(slendrinaEyes.position, targetSeePoint.position, Color.red);
				if (hitInfo.collider.gameObject.name == target.name)
				{
					myState = NPC.Idle;
					if (!(sqrMagnitude >= maximumRangeSqr))
					{
						playerHealthScript.faceGhost();
					}
					playerHealthScript.healthDecayRateBlood = killTimeLongDist;
					if (!playerFlashlightOff)
					{
						playerHealthScript.HealthDecreaseBlood();
						if (!hasPlayedSeenSoundFar)
						{
							AudioSource.PlayClipAtPoint(enemySightedSoundFar, target.position);
							hasPlayedSeenSoundFar = true;
						}
					}
					playerHealthScript.faceGhost();
					slendrinaSeePlayer = true;
				}
				else
				{
					myState = NPC.Chasing;
					playerHealthScript.HealthIncreaseBlood();
					slendrinaSeePlayer = false;
				}
			}
		}
		else
		{
			if (!(sqrMagnitude >= middleRangeSqr) && hasPlayedSeenSound)
			{
				Teleportaway();
			}
			if (!(sqrMagnitude >= maximumRangeSqr) && hasPlayedSeenSoundFar)
			{
				Teleportaway();
			}
			if (!(sqrMagnitude >= minimumRangeSqr))
			{
				myState = NPC.Idle;
			}
			else
			{
				myState = NPC.Chasing;
			}
			playerHealthScript.HealthIncreaseBlood();
			hasPlayedSeenSound = false;
			hasPlayedSeenSoundFar = false;
		}
	}

	public virtual void CheckIfVisible()
	{
		Vector3 forward = target.forward;
		Vector3 normalized = (slendrinaEyes.position - targetSeePoint.position).normalized;
		float num = Vector3.Dot(forward, normalized);
		isVisible = false;
		slendrinaSeePlayer = false;
		if (!(num <= offScreenDot))
		{
			isVisible = true;
		}
	}

	public virtual void ReduceDistance()
	{
		minimumRange -= reduceDistanceAmount;
		minimumRangeSqr = minimumRange * minimumRange;
		moveSpeed += increaseSpeedAmount;
	}

	public virtual void Moving(Vector3 lookDirection)
	{
		RaycastHit hitInfo = default(RaycastHit);
		float num = 0.2f;
		Vector3 vector = myTransform.position - myTransform.right * num;
		Vector3 vector2 = myTransform.position + myTransform.right * num;
		if (Physics.Raycast(vector, myTransform.forward, out hitInfo, rayDistance))
		{
			if (hitInfo.collider.gameObject.tag != "Terrain")
			{
				Debug.DrawLine(vector, hitInfo.point, Color.red);
				lookDirection += hitInfo.normal * 0.3f;
			}
		}
		else if (Physics.Raycast(vector2, myTransform.forward, out hitInfo, rayDistance))
		{
			if (hitInfo.collider.gameObject.tag != "Terrain")
			{
				Debug.DrawLine(vector2, hitInfo.point, Color.red);
				lookDirection += hitInfo.normal * 0.3f;
			}
		}
		else
		{
			Debug.DrawRay(vector, myTransform.forward * rayDistance, Color.yellow);
			Debug.DrawRay(vector2, myTransform.forward * rayDistance, Color.yellow);
		}
		if (!(myRigidbody.velocity.sqrMagnitude >= 1.75f))
		{
			lookDirection += myTransform.right * 20f;
		}
		Quaternion b = Quaternion.LookRotation(lookDirection);
		myTransform.rotation = Quaternion.Slerp(myTransform.rotation, b, turnSpeed * Time.deltaTime);
		desiredVelocity = myTransform.forward * moveSpeed;
		desiredVelocity.y = myRigidbody.velocity.y;
	}

	public virtual void OnCollisionEnter(Collision collision)
	{
		if (collision.collider.gameObject.tag == "Terrain")
		{
			isGrounded = true;
		}
	}

	public virtual void OnCollisionStay(Collision collision)
	{
		if (collision.collider.gameObject.tag == "Terrain")
		{
			isGrounded = true;
		}
	}

	public virtual void OnCollisionExit(Collision collision)
	{
		if (collision.collider.gameObject.tag == "Terrain")
		{
			isGrounded = false;
		}
	}

	public virtual void Teleportaway()
	{
		myTransform.position = new Vector3(UnityEngine.Random.Range(teleportPositionXmax, teleportPositionXmin), teleportPositionY, UnityEngine.Random.Range(teleportPositionZmax, teleportPositionZmin));
	}

	public virtual void Main()
	{
	}
}
