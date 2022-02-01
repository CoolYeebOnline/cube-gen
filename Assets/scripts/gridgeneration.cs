using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gridgeneration : MonoBehaviour
{

    public GameObject prefab;

    public int SizeY;
    public int SizeX;
    public int SizeZ;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int x = 0; x< SizeX; x++)
        {
            for (int y= 0; y < SizeY; y++)
            {
                for(int z =0; z < SizeZ; z++)
                {
                    GameObject newGridPiece = Instantiate(prefab, transform);
                    Vector3 newPosition = new Vector3(x, y, z);
                    newGridPiece.transform.localPosition = newPosition;
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
