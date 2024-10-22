using UnityEngine;
using UnityEngine.UI;


public class MainMenuController : MonoBehaviour
{

    private GameManager manager;
    [SerializeField] private GameObject _endingSceneTransition;

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    private void Start()
    {
        manager = GameManager.instance;
        Button[] buttons = FindObjectsByType<Button>(FindObjectsSortMode.None);
        foreach (Button button in buttons)
        {
            // Assigner un événement onClick basé sur le nom du bouton ou son rôle
            if (button.name == "PlayButton")
            {
                button.onClick.AddListener(callNextScene);
            }
            else if (button.name == "QuitButton")
            {
                button.onClick.AddListener(QuitGame);
            }

            button.onClick.AddListener(CryYoo);
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Space) )
        {
           callNextScene();
        }
    }

    // Cette méthode sera appelée lorsque le bouton "Jouer" est cliqué
    public void callNextScene()
    {
        manager.LaunchSceneWithTransi("GameScene", _endingSceneTransition);
    }

    // Cette méthode sera appelée lorsque le bouton "Quitter" est cliqué
    public void QuitGame()
    {
       manager.QuitGame();
    }

    private void CryYoo(){
        manager.CryYoo();
    }
}
