using UnityEngine;
using UnityEngine.UI;


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
        Button[] buttons = FindObjectsByType<Button>(FindObjectsSortMode.None);
        foreach (Button button in buttons)
        {
            // Assigner un événement onClick basé sur le nom du bouton ou son rôle
            if (button.name == "PlayButton")
            {
                button.onClick.AddListener(LoadScene);
            }
            else if (button.name == "QuitButton")
            {
                button.onClick.AddListener(QuitGame);
            }

            button.onClick.AddListener(CryYoo);
            // Tu peux ajouter d'autres boutons ici si nécessaire
        }
    }

    // Cette méthode sera appelée lorsque le bouton "Jouer" est cliqué
    public void LoadScene()
    {
        manager.EndCoroutineStarter();
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
