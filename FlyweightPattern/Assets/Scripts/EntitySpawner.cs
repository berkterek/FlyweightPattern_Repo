using System.Collections;
using UnityEngine;

public class EntitySpawner : MonoBehaviour
{
    [SerializeField] float _spawnRate = 0.1f;
    [SerializeField] int _spawnCount = 500;
    [SerializeField] BaseEntity _entity;

    int _currentCount = 0;

    IEnumerator Start()
    {
        float startTime = Time.realtimeSinceStartup;

        while (_currentCount < _spawnCount)
        {
            yield return null;

            Vector3 randomPosition = new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), 0f);
            Instantiate(_entity,randomPosition,Quaternion.identity);
            _currentCount++;
        }
        
        float stopTime = Time.realtimeSinceStartup;

        float elapsedTime = (stopTime - startTime) * 1000;

        Debug.Log("Time taken for Start() method: " + elapsedTime.ToString("F2") + " milliseconds");
    }
}
