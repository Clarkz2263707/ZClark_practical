using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
   public int currenthealth = 10;
    public int maxHealth = 10;
    public int scoreValue = 50;

    bool isDead;

    private void Awake()
    {
        Collider collider = GetComponent<Collider>();
        currenthealth = maxHealth;
    }

    public void TakeDamage(int damageAmount)
    {
        if (isDead) return;
        currenthealth -= damageAmount;
       
        if (currenthealth <= 0)
        {
            Destroy(gameObject);
        }

    }
}
