using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletSpeed = 20f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            GameObject nuevabala = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            nuevabala.GetComponent<Rigidbody>().linearVelocity = firePoint.forward * bulletSpeed;
        }
    }
}
