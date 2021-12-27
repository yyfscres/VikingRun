using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandManager : MonoBehaviour
{
    public GameObject[] landPrefabs;
    public GameObject[] coins;
    private float forwardSpawn = 15 ,rightSpawn=0;
    private float landLength = 9;
    public int numberOfLand = 5;
    public Transform playerTransform;
    private Vector3 direction, mainDirection = new Vector3(0, 0, 1), otherDirection = new Vector3(1, 0, 0);
    private int rotate = 0;
   
    // Start is called before the first frame update
    void Start()
    {
        
        
        Instantiate(landPrefabs[0], transform.forward * 0, transform.rotation);
        /*
        SpawnLand(1);
        SpawnLand(2);
        SpawnLand(3);
        SpawnLand(4);
        SpawnLand(5);
        */

        for (int i = 0; i < numberOfLand; i++)
        {
            SpawnLand(Random.Range(0, landPrefabs.Length));
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerTransform.position.z > forwardSpawn - (numberOfLand * landLength)){
            SpawnLand(Random.Range(0, landPrefabs.Length));
        }
        
        
    }
    public void SpawnLand(int landIndext)
    {
        if (landIndext == 4)
        {
            GameObject land = Instantiate(landPrefabs[landIndext], transform.forward * forwardSpawn + transform.right * rightSpawn, Quaternion.Euler(0, 0, 0));
            CoinSpawn(land);
            if (rotate == 0)
            {

                rotate = 1;
                rightSpawn += 15;
                Instantiate(landPrefabs[landIndext], transform.forward * forwardSpawn + transform.right * rightSpawn, Quaternion.Euler(0, 90, 0));
                rightSpawn += 15;
            }
            else if (rotate == 1)
            {
                rotate = 0;
                forwardSpawn += 15;
                Instantiate(landPrefabs[landIndext], transform.forward * forwardSpawn + transform.right * rightSpawn, Quaternion.Euler(0, 0, 0));
                forwardSpawn += 15;
            }


        }
        if (landIndext == 3)
        {
            GameObject land = Instantiate(landPrefabs[landIndext], transform.forward * forwardSpawn + transform.right * rightSpawn, Quaternion.Euler(0, 0, 0));
            CoinSpawn(land);
            if (rotate == 0)
            {
                
                rotate = 1;
                rightSpawn += 15;
                Instantiate(landPrefabs[landIndext], transform.forward * forwardSpawn + transform.right * rightSpawn, Quaternion.Euler(0, 90, 0));
                rightSpawn += 15;
            }
            else if(rotate == 1)
            {
                rotate = 0;
                forwardSpawn += 15;
                Instantiate(landPrefabs[landIndext], transform.forward * forwardSpawn + transform.right * rightSpawn, Quaternion.Euler(0, 0, 0));
                forwardSpawn += 15;
            }
            

        }
        if (landIndext == 2)
        {
            if (rotate == 0)
            {
                GameObject land = Instantiate(landPrefabs[landIndext], transform.forward * forwardSpawn + transform.right * rightSpawn, Quaternion.Euler(0, 90*Random.Range(0,4), 0));
                int h = Random.Range(0, 2);
                if (h == 1)
                {
                    CoinSpawn(land);
                }
                forwardSpawn += 15;
            }
            else if (rotate == 1)
            {
                GameObject land = Instantiate(landPrefabs[landIndext], transform.forward * forwardSpawn + transform.right * rightSpawn, Quaternion.Euler(0, 90 * Random.Range(0, 4), 0));
                int h = Random.Range(0, 2);
                if (h == 1)
                {
                    CoinSpawn(land);
                }
                rightSpawn += 15;
            }
        }
        if(landIndext < 2)
        {
            
            if (rotate == 0)
            {
                GameObject land = Instantiate(landPrefabs[landIndext], transform.forward * forwardSpawn + transform.right * rightSpawn, Quaternion.Euler(0, 0, 0));
                int h = Random.Range(0, 2);
                if (h == 1)
                {
                    CoinSpawn(land);
                }
                forwardSpawn += 15;
            }
            else if (rotate == 1)
            {
                GameObject land = Instantiate(landPrefabs[landIndext], transform.forward * forwardSpawn + transform.right * rightSpawn, Quaternion.Euler(0, 90, 0));
                int h = Random.Range(0, 2);
                if (h == 1)
                {
                    CoinSpawn(land);
                }
                rightSpawn += 15;
            }
            
        }

        
    }
    public void CoinSpawn(GameObject land)
    {
        for(int i = 0; i < Random.Range(0, 9); i++)
        {
            if (i == 0)
            {
                Instantiate(coins[Random.Range(0, 4)], land.transform.position, Quaternion.Euler(0, 0, 0));
            }
            if (i == 1)
            {
                Vector3 position = land.transform.position;
               
                Instantiate(coins[Random.Range(0, 4)], new Vector3(position.x - 5f, position.y - 0, position.z), Quaternion.Euler(0, 0, 0));
            }
            if (i == 2)
            {
                Vector3 position = land.transform.position;

                Instantiate(coins[Random.Range(0, 4)], new Vector3(position.x - 5f, position.y , position.z-5f), Quaternion.Euler(0, 0, 0));
            }
            if (i == 3)
            {
                Vector3 position = land.transform.position;

                Instantiate(coins[Random.Range(0, 4)], new Vector3(position.x - 5f, position.y , position.z+5f), Quaternion.Euler(0, 0, 0));
            }
            if (i == 4)
            {
                Vector3 position = land.transform.position;

                Instantiate(coins[Random.Range(0, 4)], new Vector3(position.x , position.y, position.z + 5f), Quaternion.Euler(0, 0, 0));
            }
            if (i == 5)
            {
                Vector3 position = land.transform.position;

                Instantiate(coins[Random.Range(0, 4)], new Vector3(position.x+5f, position.y, position.z + 5f), Quaternion.Euler(0, 0, 0));
            }
            if (i == 6)
            {
                Vector3 position = land.transform.position;

                Instantiate(coins[Random.Range(0, 4)], new Vector3(position.x + 5f, position.y, position.z ), Quaternion.Euler(0, 0, 0));
            }
            if (i == 7)
            {
                Vector3 position = land.transform.position;

                Instantiate(coins[Random.Range(0, 4)], new Vector3(position.x + 5f, position.y, position.z - 5f), Quaternion.Euler(0, 0, 0));
            }
            if (i == 8)
            {
                Vector3 position = land.transform.position;

                Instantiate(coins[Random.Range(0, 4)], new Vector3(position.x , position.y, position.z ), Quaternion.Euler(0, 0, 0));
            }

        }

    }
    private void LeftTopCoin()
    {

    }
    private void TopCoin()
    {

    }
    private void RightTopCoin()
    {

    }
    private void CenterCoin()
    {
        Instantiate(coins[0], transform.forward * forwardSpawn + transform.right * rightSpawn, Quaternion.Euler(0, 0, 0));
    }
    
}
