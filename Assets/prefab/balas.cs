using System.Runtime.CompilerServices;
using UnityEngine;

public class balas : MonoBehaviour
{
    public float speed = 10f;
    public int rebotes = 2;
    public 
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnCollisionEnter(Collision collision)
    {
        vidaenemigo enemigo = collision.gameObject.GetComponent<vidaenemigo>();
        if (enemigo != null)
        {
            enemigo.recibirDaño(1);
            GetComponent<Collider>().enabled = false; // Apagamos el choque de la bala para que no vuelva a tocar nada
            Destroy(gameObject);
            return; // ¡ESTO FRENA EL MÉTODO ACÁ Y NO REBOTA!
        }

        if (rebotes > 0)
        {
            Debug.Log("boing");
            rebotes--;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
