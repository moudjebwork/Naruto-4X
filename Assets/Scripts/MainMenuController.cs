using UnityEngine;

public class MainMenuController : MonoBehaviour
{

    private GameManager manager;

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    private void Start()
    {
        manager = GameManager.instance;
    }

    // Cette méthode sera appelée lorsque le bouton "Jouer" est cliqué
    public void LoadScene(string _sceneName)
    {
        manager.LoadScene(_sceneName);
    }

    // Cette méthode sera appelée lorsque le bouton "Quitter" est cliqué
    public void QuitGame()
    {
       manager.QuitGame();
    }
}
