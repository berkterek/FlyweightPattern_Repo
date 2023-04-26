using UnityEngine;

public class Entity : MonoBehaviour
{
    [SerializeField] StatsSO _stats;
    [SerializeField] int _currentHealth;
    [SerializeField] int _currentDamage;

    void Start()
    {
        _currentHealth = Random.Range(25, _stats.MaxHealth);
        _currentDamage = Random.Range(25, _stats.MaxDamage);
    }
}
