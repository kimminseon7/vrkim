using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SempleTileMap : MonoBehaviour
{
    public GameObject tile_001;

    // Start is called before the first frame update
    void Start()
    {
        for(int i =0; i<10; i++)
        {
            for(int j = 0; j < 10; j++)
            {
                GameObject temp = (GameObject)Instantiate(tile_001);
                temp.transform.position = new Vector3(i, 0, j);

            }
        }
        for (int j = 10; j < 20; j++)
        {
              
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
