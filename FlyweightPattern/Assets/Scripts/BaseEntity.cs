using UnityEngine;

public abstract class BaseEntity: MonoBehaviour
{
    [SerializeField] protected int _currentHealth;
    [SerializeField] protected int _currentDamage;
}