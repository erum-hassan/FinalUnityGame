﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ChapterOne
{
	public class Item : MonoBehaviour {
      private Item_Master itemMaster;
	  private Transform  myTransform;
	  private Rigidbody myRigidbody;
      public Vector3 throwDirection;

	  public bool canBeThrown;
	  public string throwButtonName;
	  public float throwForce;
	

	// Use this for initialization
	void Start () {
		

		SetInitialReferences();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void SetInitialReferences ()
	{
itemMaster = GetComponent<Item_Master>();
myTransform =  transform;
myRigidbody = GetComponent<Rigidbody>();
 
	}

	void CheckForThrowInput()


	{

   if(throwButtonName != null)
   {
	 if(Input.GetButtonDown(throwButtonName)&& Time.timeScale >0 && canBeThrown &&
     myTransform.root.CompareTag(GameManager_References. _playerTag ))   ;

	 {
		  CarryOutThrowActions();
	 }
   }
	}

	void CarryOutThrowActions()

	{
    
	 throwDirection = myTransform.parent.forward;
	 myTransform.parent = null; 
	 itemMaster.CallEventObjectThrow();
     HurlItem();
	}

    void HurlItem()

	{

  myRigidbody.AddForce(throwDirection * throwForce,ForceMode.Impulse);
	}


}
}
