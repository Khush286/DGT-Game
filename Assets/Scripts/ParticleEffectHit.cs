using UnityEngine;
using System.Collections;

/****************************** Project Header ******************************\
Script Name:  ParticleEffectHit
Project:      DGT-Game Dungeon Runner
Author:       Khushwant Singh

Handles the functions of the Particles effect.

\***************************************************************************/

[RequireComponent(typeof(ParticleSystem))]
public class ParticleEffectHit : MonoBehaviour
{
	public bool OnlyDeactivate;
	
	void OnEnable()
	{
		StartCoroutine("CheckIfAlive");
	}
	
	IEnumerator CheckIfAlive ()
	{
		ParticleSystem ps = this.GetComponent<ParticleSystem>();
		
		while(true && ps != null)
		{
			yield return new WaitForSeconds(0.5f);
			if(!ps.IsAlive(true))
			{
				if(OnlyDeactivate)
				{
						this.gameObject.SetActive(false);
				}
				else
					GameObject.Destroy(this.gameObject);
				break;
			}
		}
	}
}
