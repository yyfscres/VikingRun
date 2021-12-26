using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandManager : MonoBehaviour
{
    public GameObject[] landPrefabs;
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


        if (rotate == 0)
        {
       
            Instantiate(landPrefabs[landIndext], transform.forward * forwardSpawn + transform.right * rightSpawn, Quaternion.Euler(0, 0, 0));
            
        }
        else
        {
   
            Instantiate(landPrefabs[landIndext], transform.forward * forwardSpawn + transform.right * rightSpawn,Quaternion.Euler(0,0,0));
            
        }

        
        if (landIndext !=3)
        {
            if (rotate == 0)
            {
                forwardSpawn += 15;
            }
            else
            {
                rightSpawn += 15;
            }
        }
        if (landIndext == 3)
        {
            if (rotate == 0)
            {
                rotate = 1;
            }
            else
            {
                rotate = 0;
            }
        
            if (rotate == 0)
            {
                forwardSpawn += 15;
                Instantiate(landPrefabs[landIndext], transform.forward * forwardSpawn+transform.right*rightSpawn, Quaternion.Euler(0, 0, 0));
                
            }
            else
            {
                
                rightSpawn += 15;
                
                Instantiate(landPrefabs[landIndext], transform.forward * forwardSpawn+ transform.right * rightSpawn, Quaternion.Euler(0,0,0));
                
            }

            if (rotate == 0)
            {
                forwardSpawn += 15;
            }
            else
            {
                rightSpawn += 15;
            }

        }
        
        
        
    }
}
