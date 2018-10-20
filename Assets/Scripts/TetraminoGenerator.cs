using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetraminoGenerator : MonoBehaviour {
	[SerializeField]
	private GameObject _yellowTile;
	[SerializeField]
	private GameObject _redTile;
	[SerializeField]
	private GameObject _purpleTile;
	[SerializeField]
	private GameObject _blueTile;
	[SerializeField]
	private GameObject _greenTile;
	[SerializeField]
	private GameObject _cyanTile;
	[SerializeField]
	private GameObject _orangeTile;

	public TetraminoGenerator Inst;

	private void Awake()
	{
		if (Inst == null)
		{
			Inst = this;
		}
		else
		{
			Destroy(gameObject);
		}
	}


	public GameObject GetTileByType(TetraminoType tetramino)
	{
		GameObject tile = null;
		switch(tetramino)
		{
			case TetraminoType.I:
				tile = _cyanTile;
			break;
			case TetraminoType.J:
				tile = _blueTile;
			break;
			case TetraminoType.L:
				tile = _orangeTile;
			break;
			case TetraminoType.O:
				tile = _yellowTile;
			break;
			case TetraminoType.S:
				tile = _greenTile;
			break;
			case TetraminoType.T:
				tile = _purpleTile;
			break;
			case TetraminoType.Z:
				tile = _redTile;
			break;
		}

		return tile;
	}	
}
