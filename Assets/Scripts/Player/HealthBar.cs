using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    [SerializeField] private PlayerHealth health;
    [SerializeField] private Image bar;

    void Start()
    {
        if (health != null)
        {
            health.onHealthChanged += UpdateHealthBar;
        }
    }

    
    void UpdateHealthBar(int currentHealth, int maxHealth)
    {
        bar.fillAmount = (float)currentHealth / maxHealth;
    }
}
