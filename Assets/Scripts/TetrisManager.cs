using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetrisManager
{
	public Vector2[,] grid = new Vector2[10, 24];

	public TetrisGameState GameState { get; private set; }
	public bool IsBlockAlive { get; set; }
	public bool IsGameOver
	{
		get { return GameState == TetrisGameState.Over; }
	}

	public TetraminoType curType;

	public void SpawnBlock()
	{
		TetraminoType tetramino = GetRandomType();
		
	}

	private TetraminoType GetRandomType()
	{
		int len = System.Enum.GetNames(typeof(TetraminoType)).Length;
		int result = UnityEngine.Random.Range(1, len);

		return (TetraminoType) result;
	}

	public void SetGameStateStart()
	{
		GameState = TetrisGameState.Start;
	}

	public enum TetrisGameState
	{
		None,
		Start,
		Pause,
		Over,
	}
}



