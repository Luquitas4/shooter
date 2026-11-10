using UnityEngine;
using TMPro;
public class vidajugador : MonoBehaviour
{
    public int vida = 5;
    public TextMeshProUGUI textoVida;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void recibirDaño(int daño)
    {
        vida -= daño;
        textoVida.text = "Vida: " + vida; // Actualiza el texto en vivo

        if (vida <= 0)
        {
            FindAnyObjectByType<GameManager>().PerderPartida();
        }
    }
}
