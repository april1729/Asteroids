using UnityEngine;
using System.Collections;

/// <summary>
/// Creating instance of sounds from code with no effort
/// </summary>
public class soundEffectHelper : MonoBehaviour
{
	
	/// <summary>
	/// Singleton
	/// </summary>
	public static soundEffectHelper Instance;
	

	public AudioClip explosionSound1;
	public AudioClip explosionSound2;

	public AudioClip explosionSound3;


	public AudioClip thrustSound;
	public AudioClip beepSound;
	public AudioClip boopSound;

	public AudioClip enemyFireSound;
	public AudioClip fireSound;	
	void Awake()
	{
		// Register the singleton
		if (Instance != null)
		{
			Debug.LogError("Multiple instances of SoundEffectsHelper!");
		}
		Instance = this;
	}
	
	public void MakeExplosionSound1()
	{
		MakeSound(explosionSound1);
	}
	public void MakeExplosionSound2()
	{
		MakeSound(explosionSound2);
	}	
	public void MakeExplosionSound3()
	{
		MakeSound(explosionSound3);
	}

	
	public void MakeThrustSound()
	{
		MakeSound(thrustSound);
	}
	
	public void MakeBeepSound()
	{
		MakeSound(beepSound);
	}

	public void MakeBoopSound()
	{
		MakeSound(boopSound);
	}
	public void MakeEnemyFireSound()
	{
		MakeSound (enemyFireSound);
		}
	public void MakeFireSound()
	{
		MakeSound (fireSound);
	}

	/// <summary>
	/// Play a given sound
	/// </summary>
	/// <param name="originalClip"></param>
	private void MakeSound(AudioClip originalClip)
	{
		// As it is not 3D audio clip, position doesn't matter.
		AudioSource.PlayClipAtPoint(originalClip, transform.position);
	}
}
