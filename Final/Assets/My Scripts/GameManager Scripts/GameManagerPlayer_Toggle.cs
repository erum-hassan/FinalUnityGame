using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

namespace ChapterOne
{

public class GameManagerPlayer_Toggle : MonoBehaviour {

	public FirstPersonController playerController;
	private GameManager_Master gameManagerMaster;

	void OnEnable()
	{
    SetInitialReferences();
	gameManagerMaster.MenuToggleEvent += TogglePlayerController;
	gameManagerMaster.InventoryUIToggleEvent+=TogglePlayerController;

	}

	void OnDisable()

	{
  gameManagerMaster.MenuToggleEvent -= TogglePlayerController;
	gameManagerMaster.InventoryUIToggleEvent -= TogglePlayerController;
	}

	void SetInitialReferences()
	{
   gameManagerMaster = GetComponent<GameManager_Master>();
	}

	void TogglePlayerController()

	{

		 if(playerController != null)
		 {
			 playerController.enabled = !playerController.enabled;
		 }
	}
}
}
