using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChapterOne
{
	public class GameManager_References : MonoBehaviour {

public string playerTag;
public static string _playerTag;

public  string enemyTag;
public static string _enemyTag;

public static GameObject _player;

void OnEnable()
{
	if(playerTag == "")
	{
		Debug.LogWarning("Please type inthe name of the player tag inthe GameManager_References" + "slot inthe inspector or else the Final series systems will not work");
		
	}

	if(enemyTag =="")
	{
		Debug.LogWarning("Plese type inthe name of the enemy Tag in the GameManager_References " + "slot int the inspector or the Final series will not work");
	}

	_playerTag = playerTag;
	_enemyTag = enemyTag;

	 _player = GameObject.FindGameObjectWithTag(_playerTag);
}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

}