using UnityEngine;
using UnityEngine.AI;
public class enemigoia : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        if (agent.enabled && player != null)
        {
            agent.SetDestination(player.position);
        }
      
    }
}
