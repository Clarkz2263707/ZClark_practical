using System;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] public int maxHealth = 100;
    [SerializeField] public int currenthealth;
    public event Action<int, int> onHealthChanged;

    public void Awake()
    {
        currenthealth = maxHealth;
    }
    void Update()
    {

    }

    public bool IsDead()
    {
        return currenthealth > 0;
    }

    public void TakeDamage(int damageAmount)
    {

        if (currenthealth > 0)
        {
            currenthealth = Mathf.Max(currenthealth - damageAmount, 0);
            onHealthChanged?.Invoke(currenthealth, maxHealth);
        }
        Debug.Log($"Player took {damageAmount} damage. Current health: {currenthealth}");
    }
}
