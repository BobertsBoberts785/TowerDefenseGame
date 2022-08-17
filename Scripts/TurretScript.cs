using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretScript : MonoBehaviour
{
    public float shootTime = 2f;

    [SerializeField] private GameObject prefab;
    [SerializeField] private Vector3 spawnPosition;
    [SerializeField] private bool random;

    private void Start()
    {
        Delay1();
    }

    public void SpawnPrefab()
    {
        if(random)
        {
            float x = Random.Range(-8, 8);
            float y = Random.Range(-4, 4);
            float z = Random.Range(-8, 8);
            Instantiate(prefab, new Vector3(x, y, z), Quaternion.identity);
        }
        else
        {
            Instantiate(prefab, spawnPosition, Quaternion.identity);
        }
    }

    private void Delay1()
    {
        SpawnPrefab();
        Invoke("Delay1", shootTime);
    }
}
