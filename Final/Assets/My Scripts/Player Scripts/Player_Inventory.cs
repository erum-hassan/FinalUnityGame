using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace ChapterOne
{

	public class Player_Inventory: MonoBehaviour {

     public Transform inventoryPlayerParent;
	 public Transform InventoryParent;
	 public GameObject uiButton;

	 private Player_Master playerMaster;
	 private GameManager_ToggleInventoryUI inventoryUIScript;
	 private float timeToPlaceInHands;
	 private init counter;
	 private string buttonText;
	 private  List<Transform>() = new List<Transform>();  
	
	void OnEnable()

	{
SetInitialReferences();
UpdateInventoryListAndUI();
CheckIfHandsEmpty();

playerMaster.EventInventoryChanged += UpdateInventoryListAndUI;
playerMaster.EventInventoryChanged += CheckIfHandsEmpty;
playerMaster.EventIfHandsEmpty += ClearHands;
	}

	void OnDisable()
	{

    playerMaster.EventInventoryChanged -= UpdateInventoryListAndUI;
playerMaster.EventInventoryChanged -= CheckIfHandsEmpty;
playerMaster.EventIfHandsEmpty -= ClearHands;
	}


	void SetInitialReferences()
	{
    inventoryUIScript = GameObject.Find("GameManager").GetComponent<GameManager_TogggleInventoryUI>();
	playerMaster = GetComponent<Player_Master>();

	}

	void UpdateInventoryListAndUI(){


	}

	void CheckIfHandsEmpty()
	{


	}

	void ClearHands()
	{


	}

	void ClearInventoryUI(){


	}

	public void ActivateInventoryItems(int inventoryIndex)
	{


	}

	void DeactivateAllInventoryItems(){

         foreach(Transform child in inventoryPlayerParent)
	}

	IEnumerator PlaceItemInHands(Transform itemTransform)
	{
     yield return new WaitForSeconds(timeToPlaceInHands);
  currentlyHeldItem = itemTransform;
  currentlyHeldItem.gaemObject.SetActive(true);
	}

	p






}
}
