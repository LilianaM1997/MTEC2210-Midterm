using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class CoinSpawn : MonoBehaviour
{
    public GameObject coin;
    public float X;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 RandomCoinPosition = new Vector3(Random.Range(-10, 10), 0, 0);
          Instantiate(coin,RandomCoinPosition, Quaternion.identity);
        }
        
    }
   
}
