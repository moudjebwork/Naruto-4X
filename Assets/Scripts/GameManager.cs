using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public static GameManager instance {private set; get; }

    private static float endDelay = 1.5f;

    [SerializeField] private GameObject _startingSceneTransition;
    [SerializeField] private GameObject _endingSceneTransition;
    public void Awake()
    {

        if(instance != null){
            Destroy(gameObject);
            return;
        }

        instance = this;
    }

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    private void Start()
    {
        // _startingSceneTransition.SetActive(true);
        // StartCoroutine(WaitBeforeFinishStart(5f));
    }

    IEnumerator WaitBeforeFinishStart(float delay)
    {
        yield return new WaitForSeconds(delay);
        DisableStartingTransition(); // Appelle ta fonction ici
    }

    private void DisableStartingTransition()
    {
        _startingSceneTransition.SetActive(false);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Space) )
        {
           EndCoroutineStarter();
        }
    }

    public void EndCoroutineStarter(){
         _endingSceneTransition.SetActive(true);
        StartCoroutine(LaunchEndTransition());
    }

    IEnumerator LaunchEndTransition()
    {
        yield return new WaitForSeconds(endDelay);
        LoadSceneProcess(); // Appelle ta fonction ici
    }


    private void LoadSceneProcess()
    {
        Debug.Log("Load Game scene ");
        // Charger la scène de jeu principale
        SceneManager.LoadScene("GameScene"); 
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
