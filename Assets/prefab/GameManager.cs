using UnityEngine;
using TMPro; // Obligatorio para TextMeshPro
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour

{
    public TextMeshProUGUI textoEnemigos;
    public TextMeshProUGUI textoFinJuego;
    public GameObject cuboMeta;
    private int enemigosRestantes;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        vidaenemigo[] enemigos = FindObjectsByType<vidaenemigo>();
        enemigosRestantes = enemigos.Length;
        textoEnemigos.text = "Abuelas restantes: " + enemigosRestantes;
        cuboMeta.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RestarEnemigo()
    {
        enemigosRestantes--;
        textoEnemigos.text = "Abuelas restantes: " + enemigosRestantes;

        if (enemigosRestantes <= 0)
        {
            cuboMeta.SetActive(true); // ¡Aparece el cubo gigante!
            textoEnemigos.text = "¡ENTRA AL CUBO PARA ESCAPAR!";
        }
    }
    public void GanarPartida()
    {
        textoFinJuego.gameObject.SetActive(true);
        textoFinJuego.text = "¡VICTORIA!";
        Time.timeScale = 0f; // Pausa el juego
    }
    public void PerderPartida()
    {
        textoFinJuego.gameObject.SetActive(true);
        textoFinJuego.text = "¡PERDISTE!";
        Invoke(nameof(ReiniciarNivel), 2f); // Espera 2 segundos de reloj
    }

    void ReiniciarNivel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
