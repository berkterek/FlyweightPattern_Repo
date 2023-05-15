using UnityEngine;

public class EntityWithWithoutScriptableObject : BaseEntity
{
    [SerializeField] int _maxHealth = 100;
    [SerializeField] int _maxDamage = 100;
    
    void Start()
    {
        _currentHealth = Random.Range(25, _maxHealth);
        _currentDamage = Random.Range(25, _maxDamage);
    }
}