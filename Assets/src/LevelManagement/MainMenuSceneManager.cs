using UnityEngine;

public class MainMenuSceneManager : SimpleSceneManager {

    [SerializeField] protected StringScriptableValue lastSceneToLoad;
    
    [SerializeField] protected string loadingSceneName = "LoadingScreen";

    public void StartGame() {
        lastSceneToLoad.SetValue("Day1");
        LoadScene(loadingSceneName);
    }
    
    public void ContinueGame() {
        lastSceneToLoad.SetValue(GetLastPlayedScene());
        LoadScene(loadingSceneName);
    }

    public string GetLastPlayedScene() {
        return "Day2";
    }
}
