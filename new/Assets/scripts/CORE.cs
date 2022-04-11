using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CORE : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform spawnPoint;

    private static List<GameObject> theRooms = new List<GameObject>();
    public static void addRoomGO(GameObject go)
    {
        CORE.theRooms.Add(go);
        print("Added Room");
    }
    //private List<GameObject> eSpawns = new List<GameObject>(); not needed, remove later

    public void randomEnemyMove()
    {
        for (int i = 0; i < 20; i++)
        
            Transform eTransform = Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
            eTransformt.GetComponent<Rigidbody>().velocity = new Vector3(Random.Range(10, 50), Random.Range(0, 50), Random.Range(10, 50));
        }

    }

    public static void display()
    {
        print("Woot");
    }

    // Start is called before the first frame update
    void Start()
    {
        randomEnemyMove();
    }

    // Update is called once per frame
    void Update()
    {
    
    }
}
