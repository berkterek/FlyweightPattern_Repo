using UnityEngine;

public class EntityWithScriptableObject : BaseEntity
{
    [SerializeField] StatsSO _stats;
    
    void Start()
    {
        _currentHealth = Random.Range(25, _stats.MaxHealth);
        _currentDamage = Random.Range(25, _stats.MaxDamage);
    }
}