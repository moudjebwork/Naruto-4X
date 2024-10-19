using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance {private set; get; }

    public void Awake()
    {

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Persiste à travers les scènes
        }
        else
        {
            Destroy(gameObject);
        }

    }

    public void LoadScene(string _sceneName)
    {
        Debug.Log("Load scene " + _sceneName);
        // Charger la scène de jeu principale
        SceneManager.LoadScene(_sceneName); 
    }

    public void QuitGame()
    {
        Debug.Log("Quit game");
        // Quit game
        Application.Quit();
    }
}
