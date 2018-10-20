using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetrisContainerController : MonoBehaviour
{

	public float updateStep = 1f;

	private TetrisManager _manager;

	private Coroutine _gameloopCoro;

	private void Start()
	{
		_manager = new TetrisManager();
	}

	private void StartGame()
	{
		_manager.SetGameStateStart();
		_gameloopCoro = StartCoroutine(StartGameLoop());
	}

	private IEnumerator StartGameLoop()
	{
		float curTime = Time.time;
		while ((Time.time - curTime) < updateStep)
		{
			yield return null;
		}
		
		
	}
	
}
