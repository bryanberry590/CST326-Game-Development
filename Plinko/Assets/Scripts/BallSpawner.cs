using UnityEngine;

public class BallSpawner : MonoBehaviour
{

    public GameObject ballPrefab;
    // public Transform spawnLocation;
    // private GameObject[] spawnerLocations = new GameObject[7];
    private float totalTime;
    private float randX = 0f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        totalTime = Time.deltaTime;
        // for(int i = 0; i < spawnerLocations.Length; i++)
        // {
        //     spawnerLocations[i] = GameObject.Find($"/SpawnLocations/SpawnLocation{i+1}");
        //                //Debug.Log(spawnerLocations[i].name);
        // }
    }

    // Update is called once per frame
    void Update()
    {
        totalTime += Time.deltaTime;
        if(totalTime > 1) {
            if(Input.GetKey(KeyCode.Space)){
                randX = Random.Range(-1.0f,1.1f);


                // Transform spawnerTransform = spawnerLocations[rand].GetComponent<Transform>();
                Vector3 spawnPos = new Vector3(randX, 2.0f, 0f);

                //create new ball instance at spawnPos
                GameObject newBall = Instantiate(ballPrefab, spawnPos, Quaternion.identity);
                //Debug.Log(newBall.name);
                totalTime = 0;            
            }   
        }
        
    }
}
