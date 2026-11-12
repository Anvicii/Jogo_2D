using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuScene : MonoBehaviour
{
    public GameObject painelPause;
    public GameObject painelGameOver;

    bool pausado = false;
    bool jogoAcabou = false;


    void Start()
    {
        painelPause.SetActive(false);
        painelGameOver.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pausado)
            {
                Continuar();
            }else
            {
                Pausar();
            }
        }
    }

    public void Pausar()
    {
        if(jogoAcabou == false)
        {
            pausado = true;
            painelPause.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void Continuar()
    {
        pausado = false;
        painelPause.SetActive(false);
        Time.timeScale = 1f;
    }

    public void MostrarGameOver()
    {
        jogoAcabou = true;
        painelGameOver.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Reiniciar()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
