using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileManager : MonoBehaviour
{
    public Tilemap grassMap;

    public Tilemap wallMap;

    public TileBase dirtTile;

    private static TileManager instance = null;
    public static TileManager sharedInstance
    {

        //Accesseur automatique
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<TileManager>();
            }
            return instance;
        }
    }

    public void EatGrassTile(Vector3Int position)
    {
        wallMap.SetTile(position, dirtTile);
    }
}
