using UnityEditor;
using UnityEngine;

public class moveToAcross : MonoBehaviour
{

    public GameObject[] npcPrefabs; // Drop your guy prefabs here
    public float spawnInterval = 5.0f; // Seconds between spawns
    private float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnNPC();
            timer = 0;
        }
    }

    void SpawnNPC()
    {
        int randomIndex = Random.Range(0, npcPrefabs.Length);
        Instantiate(npcPrefabs[randomIndex], transform.position, transform.rotation);
    }
}
