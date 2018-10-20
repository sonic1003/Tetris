using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tetramino {
    
    public TetraminoType Type { get; private set; }
    public Vector2[] coord = new Vector2[4];

    private Tile _centerTile;

    public Tetramino(TetraminoType type, Vector2[] coord)
    {
        this.Type = type;
        this.coord = coord;
    }

    public void RotateLeft()
    {
        
    }

    public void RotateRight()
    {
        
    }
}

public class Tile
{
    public Vector2 coord;

    public Tile(Vector2 coord)
    {
        this.coord = coord;
    }
}

public enum TetraminoType
{
    None,
    I,
    O,
    T,
    S,
    Z,
    J,
    L,
}
