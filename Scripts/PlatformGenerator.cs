using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    public GameObject platformPrefab;
    private void Start()
    {
        Vector2 spawnerPosition = new Vector2();
        for (int i = 0; i < 10; i++)
        {
            spawnerPosition.x = Random.Range(-1.7f, 1.7f);
            spawnerPosition.y += Random.Range(2f, 3.5f);

            Instantiate(platformPrefab, spawnerPosition, Quaternion.identity);
        }
    }
}
