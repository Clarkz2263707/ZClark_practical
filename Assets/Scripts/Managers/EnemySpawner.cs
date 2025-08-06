using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Transform[] spawnPoints;
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private int minEnemiesPerWave = 1;
    [SerializeField] private int maxEnemiesPerWave = 5;
    [SerializeField] private float spawnIntervalMin = 1f;
    [SerializeField] private float spawnIntervalMax = 5f;
    

    private GameObject player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        StartWave();  
    }

    
    void Update()
    {
        
    }

    private void StartWave()
    {
        int numEnemiesToSpawn = Random.Range(minEnemiesPerWave, maxEnemiesPerWave);
        Debug.Log(numEnemiesToSpawn + " enemies to spawn this wave.");
        for (int i = 0; i < numEnemiesToSpawn; i++)
        {
            SpawnEnemy();
        }
        Invoke("StartWave", Random.Range(spawnIntervalMin, spawnIntervalMax));
    }

    private void SpawnEnemy()
    {
        int spawnIndex = Random.Range(0, spawnPoints.Length);
        Vector3 spawnPosition = spawnPoints[spawnIndex].position + new Vector3(0, 2f, 0);
        GameObject EnemyInstance = Instantiate(enemyPrefab, spawnPosition, spawnPoints[spawnIndex].rotation);
        EnemyInstance.GetComponent<EnemyMovement>().SetPlayer(player, player.GetComponent<PlayerHealth>());
    }
}
