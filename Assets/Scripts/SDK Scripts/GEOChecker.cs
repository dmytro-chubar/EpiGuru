using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class GEOChecker : MonoBehaviour
{
    [SerializeField] private string _loadSceneName;
    private readonly string _apiUrl = "https://api.ipapi.com/api/check?access_key=7babeb768f2d3c73dbd9f738a4391a26";

    private void Start() =>
        StartCoroutine(CheckGEO());

    private IEnumerator CheckGEO()
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(_apiUrl))
        {
            yield return webRequest.SendWebRequest();

            if (webRequest.result != UnityWebRequest.Result.Success)
                Debug.LogError("Error fetching GEO data: " + webRequest.error);
            else
            {
                var jsonResponse = webRequest.downloadHandler.text;
                GEOResponse response = JsonUtility.FromJson<GEOResponse>(jsonResponse);

                if (response.country_code == "UA")
                    ShowGame();
                else
                    ShowWikipedia();
            }
        }
    }

    private void ShowGame() =>
        SceneManager.LoadScene(_loadSceneName);

    private void ShowWikipedia() =>
        Application.OpenURL("https://uk.wikipedia.org/");

    [System.Serializable]
    private class GEOResponse
    {
        public string country_code;
    }
}
