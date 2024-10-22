using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public static GameManager instance {private set; get; }

    public void Awake()
    {

        if(instance != null){
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void LaunchSceneWithTransi(string _nextScene, GameObject _endingSceneTransition){
         _endingSceneTransition.SetActive(true);
        StartCoroutine(LaunchEndTransition(_nextScene));
    }


    IEnumerator LaunchEndTransition(string nextScene)
    {

        yield return new WaitForSeconds(1.5f);
        LoadScene(nextScene); // Appelle ta fonction ici
    }

    private void LoadScene(string nextScene)
    {
        // Charger la scène de jeu principale
        SceneManager.LoadScene(nextScene); 
    }

    public void QuitGame()
    {
        Debug.Log("Quit game");
        // Quit game
        Application.Quit();
    }

    public void CryYoo(){
        AudioManager.instance.PlaySFX("Yoo");
    }

}
