using UnityEngine;
using System.Collections;


public class GSGM : MonoBehaviour
{
    public static GSGM instance {private set; get; }

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

    private void Start()
    {
        _startingSceneTransition.SetActive(true);
        StartCoroutine(WaitBeforeFinishStart(3f));
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

}
