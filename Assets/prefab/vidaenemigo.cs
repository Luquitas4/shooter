using UnityEngine;
using UnityEngine.AI;

public class vidaenemigo : MonoBehaviour
{
   private NavMeshAgent agent;
    private CapsuleCollider collider;
    public int vida = 3;
    public Animator Animator;
    public float ataqueporsegundo = 1f;
    private float  proximoataque = 0f;
    public Transform player;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        collider = GetComponent<CapsuleCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {

        

        float distancia = Vector3.Distance(transform.position, player.position);
            if (vida > 0 && distancia <= 2f && Time.time >= proximoataque)
            {
                proximoataque = Time.time + 1f / ataqueporsegundo;
                player.GetComponent<vidajugador>().recibirDaño(1);
                Animator.SetTrigger("atacado");
            }
           
    }
}
    public void recibirDaño(int daño)
    {
        vida -= daño;
        Debug.Log("vida enemigo: " + vida);
        if (vida <= 0)
        {
         agent.enabled = false;
            collider.enabled = false;
            Destroy(gameObject, 5f);
            Animator.SetTrigger("muerto");
            FindAnyObjectByType<GameManager>().RestarEnemigo();

        }
        if (vida == 1)
        {
            Animator.SetTrigger("herido");
        }
    }
}
