﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChapterOne
{
	public class Gun_Master : MonoBehaviour {

     public delegate void GeneralEventHandler();
	 public event GeneralEventHandler EventPlayerInput;
	 public event GeneralEventHandler EventGunNotUsable;
	 public event GeneralEventHandler EventRequestReload;
	 public event GeneralEventHandler EventRequestGunReset;
	 public event GeneralEventHandler EventToggleBarsFire;

	 public delegate void GunHitEventHandler(Vector3 hitPosition,Transform hitTransform);
	 public event GunHitEventHandler EventShotDefault;
	 public event GunHitEventHandler EventShotEnemy;
	 
	 public delegate void GunAmmoEventHandler(int currentAmmo, int carriedAmmo);
	 public event GunAmmoEventHandler EventAmmoChanged;

	 public delegate void  GunCrossHairEventHandler(float speed);
	 public event GunCrossHairEventHandler EventSpeedCaptured;

	 public bool isGunLoaded;
	 public bool isReloading;

	public void CallEventPlayerInput()
	{
		if(EventPlayerInput != null)
		{
			EventPlayerInput();
		}
	}

	public void CallEventGunNotUsable()
	{
		if(EventGunNotUsable != null)
		{
			EventGunNotUsable();
		}
	}

	public void CallEventRequestReloadt()
	{
		if(EventRequestReload != null)
		{
			EventRequestReload();
		}
	}
	public void CallEventRequestGunReset()
	{
		if(EventRequestGunReset != null)
		{
			EventRequestGunReset();
		}
	}
	public void CallEventToggleBurstFiret()
	{
		if(EventToggleBarsFire != null)
		{
			EventToggleBarsFire();
		}
	}
	public void CallEventShotDefault(Vector3 hPos,Transform hTransform)
	
	{
		if(EventShotDefault != null)
		{
			EventShotDefault(hPos,hTransform);
		}
	}
	public void CallEventShotEnemy(Vector3 hPos,Transform hTransform)
	{
		if(EventShotEnemy != null)
		{
			EventShotEnemy(hPos, hTransform);

		}
	}

	public void CallEventAmmoChanged(int curAmmo, int carAmmo)
	{
		if(EventAmmoChanged!= null)
		{
			EventAmmoChanged(curAmmo,carAmmo);
		}
	}
	public void CallEventSpeedCaptured(float spd)
	{
		if(EventSpeedCaptured != null)
		{
			EventSpeedCaptured(spd);
		}
	}
}
}
