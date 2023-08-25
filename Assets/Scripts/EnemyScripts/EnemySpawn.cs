// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class EnemySpawn : MonoBehaviour
// {
//     public GameObject prefabToSpawn;
//     public int numberOfPrefabs = 10;

//     private List<Vector2> spawnPoints = new List<Vector2>
//     {
//             new Vector2(-5.2f, 10.8f),
//             new Vector2(5f, 10.8f),
//             new Vector2(5f, 34.2f),
//             new Vector2(-34.4f, 30f),
//             new Vector2(-34.4f, 34.4f),
//             new Vector2(-34.4f, 44.6f),
//             new Vector2(-17.3f, 44.3f),
//             new Vector2(6f, 44.3f),
//             new Vector2(16.4f, 34.1f),
//             new Vector2(16f, 11f),
//             new Vector2(16f, 0f),
//             new Vector2(20f, -17f),
//             new Vector2(3f, -22f),
//             new Vector2(35f, -23f),
//             new Vector2(7f, -33.8f),
//             new Vector2(29f, -33.8f),
//             new Vector2(-34.8f, -12f),
//             new Vector2(-16.2f, -12f),
//             new Vector2(-34.8f, 18.7f),
//             new Vector2(-16.2f, 18.7f),
//             new Vector2(-45.2f, 29f),
//             new Vector2(-53.5f, 29f),
//             new Vector2(-45.2f, 35f),
//             new Vector2(-53.5f, 35f),
//             new Vector2(-45.2f, 19.7f),
//             new Vector2(-45.5f, 3.5f),
//             new Vector2(-15.5f, 0.3f),
//             new Vector2(-45.5f, -17.3f)
//     };

//     public static List<GameObject> spawnedPrefabs = new List<GameObject>();
//     public Sprite mspistol;
//     public CreateResourceBoxes instance;
//     public Transform parentTransform;
    
//     void Awake()
//     {
//         instance = this;
        
//         if (prefabToSpawn == null)
//         {
//             Debug.LogError("Prefab not assigned!");
//             return;
//         }

//         if (spawnPoints.Count < numberOfPrefabs)
//         {
//             Debug.LogError("Not enough spawn points for the specified number of prefabs.");
//             return;
//         }

//         // Shuffle the spawn points
//         ShuffleList(spawnPoints);

//         for (int i = 0; i < numberOfPrefabs; i++)
//         {
//             Vector3 randomPosition = new Vector3(spawnPoints[i].x, spawnPoints[i].y, 0f);
//             GameObject spawnedPrefab = Instantiate(prefabToSpawn, randomPosition, Quaternion.identity, parentTransform);

//             spawnedPrefabs.Add(spawnedPrefab);
//         }
//     }

//     void ShuffleList<T>(List<T> list)
//     {
//         int n = list.Count;
//         while (n > 1)
//         {
//             n--;
//             int k = Random.Range(0, n + 1);
//             T value = list[k];
//             list[k] = list[n];
//             list[n] = value;
//         }
//     }
// }
