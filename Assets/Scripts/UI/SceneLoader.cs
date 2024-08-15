using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private string _sceneName;

    private void Start () {
        GetComponent<Button>().onClick.AddListener(SceneLoad);
    }

    private void SceneLoad () {
        SceneManager.LoadScene(_sceneName);
    }
}
