using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject enemy;
    public float timeBetweenSpawn = 1f;
    public float decreaseAmount;
    public float minTime;
    
    
    private float timer;
    private float currentTimeBetweenSpawn;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer=timeBetweenSpawn;
        currentTimeBetweenSpawn=timeBetweenSpawn;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer <= 0f)
        {
            currentTimeBetweenSpawn -= decreaseAmount;
            if (currentTimeBetweenSpawn < minTime)
            {
                currentTimeBetweenSpawn = minTime;
            }
            //do the spawn
            //we need the position (x,y,z)
            float x = Random.Range(-12f, 3f);
            float y = 2.0f;
            Vector3 spawnPosition = new Vector3(x,y,0.0f);
            //what we are spawning (the Enemy)
            //spawn
            Instantiate(enemy, spawnPosition, Quaternion.identity);
            //reset the timer
            timer = currentTimeBetweenSpawn;
            
        }
        else
        {
            timer -= Time.deltaTime;
        }
    }
}
