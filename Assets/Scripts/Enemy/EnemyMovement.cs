using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    Transform player;
    PlayerHealth playerHealth;
    EnemyHealth enemyhealth;
    NavMeshAgent nav;

    public void SetPlayer(GameObject Player, PlayerHealth playerHealth)
    {
        player = Player.transform;
        this.playerHealth = playerHealth;
    }

    private void Awake()
    {
        enemyhealth = GetComponent<EnemyHealth>();
        nav = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (enemyhealth.currenthealth > 0 && playerHealth != null && playerHealth.currenthealth > 0)
        {
            nav.SetDestination(player.position);
        }
    }
}
