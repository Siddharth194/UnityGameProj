using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemyprefab;
    public List<Vector2> spawnPoints = new List<Vector2>
    {
        new Vector2(-10.2f, 5.5f), new Vector2(-10.2f, -9f), new Vector2(-10.2f, -18.5f),
        new Vector2(-10.2f, 23.9f), new Vector2(-10.2f, 16f), new Vector2(-25.5f, 25.7f),
        new Vector2(-40f, 25.7f), new Vector2(-57.5f, 25.7f), new Vector2(-40f, 5.5f),
        new Vector2(-40f, -5f), new Vector2(-40f, -13f), new Vector2(-40f, -18.5f),
        new Vector2(-40f, 16f), new Vector2(-40f, 40f), new Vector2(-40f, 32.5f),
        new Vector2(-57.5f, 32.5f), new Vector2(-57.5f, 40f), new Vector2(-25.2f, -18f),
        new Vector2(0f, 5.5f), new Vector2(10f, 5.5f), new Vector2(28f, 5.5f),
        new Vector2(10f, -9f), new Vector2(10f, -27f), new Vector2(2.1f, -27.6f),
        new Vector2(2.1f, -40f), new Vector2(2.1f, -50.7f), new Vector2(11f, 50.7f),
        new Vector2(29f, 50.7f), new Vector2(15f, -27.6f), new Vector2(28.7f, -27.6f),
        new Vector2(37.6f, -27.6f), new Vector2(37.6f, -40f), new Vector2(-37.6f, 50.7f),
        new Vector2(28.7f, -9f), new Vector2(28.7f, -27f), new Vector2(28.7f, 5.4f),
        new Vector2(10f, 16f), new Vector2(10f, 27.7f), new Vector2(10f, 39f),
        new Vector2(-24f, 40f), new Vector2(-6.7f, 40f)
    };

    private List<Vector2> pickedPositions = new List<Vector2>();
    private List<GameObject> spawnedPrefabs = new List<GameObject>();
    public EnemySpawn instance;
    public Transform parentTransform;

    private void Awake()
    {
        instance = this;    
    }

    public void PickRandomElements(int numberOfElementsToPick)
    {

        pickedPositions.Clear();

        ShuffleList(spawnPoints);

        for (int i = 0; i < numberOfElementsToPick; i++)
        {
            Vector3 randomPosition = new Vector3(spawnPoints[i].x, spawnPoints[i].y, 0f);
            GameObject spawnedPrefab = Instantiate(enemyprefab, randomPosition, Quaternion.identity, parentTransform);
            spawnedPrefabs.Add(spawnedPrefab);
        }
    }

    void ShuffleList<T>(List<T> list)
    {
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = Random.Range(0, n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }
}
