using System.Runtime.CompilerServices;
using UnityEngine;

public class balas : MonoBehaviour
{
    public float speed = 10f;
    public int rebotes = 2;
    
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
        if (rebotes > 0)
        {
            Debug.Log ("boing");
            rebotes--;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
