using System;
using UnityEngine;
using UnityScript.Lang;

[Serializable]
public class findcollideparticles : MonoBehaviour
{
	public float burstEnergy;

	public Transform explosionObject;

	public findcollideparticles()
	{
		burstEnergy = 10f;
	}

	public virtual void LateUpdate()
	{
		Particle[] particles = GetComponent<ParticleEmitter>().particles;
		int[] array = new int[Extensions.get_length((System.Array)particles)];
		int num = 0;
		for (int i = 0; i < GetComponent<ParticleEmitter>().particleCount; i++)
		{
			if (!(particles[i].energy <= burstEnergy))
			{
				particles[i].color = Color.yellow;
				if ((bool)explosionObject)
				{
					UnityEngine.Object.Instantiate(explosionObject, particles[i].position, Quaternion.identity);
				}
			}
			else
			{
				array[num++] = i;
			}
		}
		Particle[] array2 = new Particle[num];
		for (int j = 0; j < num; j++)
		{
			array2[j] = particles[array[j]];
		}
		GetComponent<ParticleEmitter>().particles = array2;
	}

	public virtual void Main()
	{
	}
}
