using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public int damageAmount = 10;

    GameObject player;
    PlayerHealth playerHealth;
    EnemyHealth enemyhealth;

    private void SetPlayer(GameObject Player, PlayerHealth playerHealth)
    {
       player = Player;
       this.playerHealth = playerHealth;
    }

    private void Awake()
    {
        enemyhealth = GetComponent<EnemyHealth>();
        player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            playerHealth = player.GetComponent<PlayerHealth>();
            SetPlayer(player, playerHealth);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && playerHealth != null && enemyhealth != null && enemyhealth != null) 
        {
            Debug.Log("Enemy attacked the player!");
            playerHealth.TakeDamage(damageAmount);
            Destroy(gameObject);
        }
    }


}
