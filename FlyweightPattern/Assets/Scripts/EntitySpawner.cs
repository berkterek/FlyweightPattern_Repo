using System.Collections;
using UnityEngine;

public class EntitySpawner : MonoBehaviour
{
    [SerializeField] float _spawnRate = 0.1f;
    [SerializeField] int _spawnCount = 500;
    [SerializeField] Entity _entity;

    int _currentCount = 0;

    IEnumerator Start()
    {
        var wait = new WaitForSeconds(_spawnRate);
        while (_currentCount < _spawnCount)
        {
            yield return wait;

            Vector3 randomPosition = new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), 0f);
            Instantiate(_entity,randomPosition,Quaternion.identity);
        }
    }
}
