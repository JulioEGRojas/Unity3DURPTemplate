using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SimpleSceneManager : MonoBehaviour {

    public void LoadSceneAdditive(string sceneName) {
        SceneManager.LoadScene(sceneName,LoadSceneMode.Additive);
    }

    public void ReloadCurrentScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    public void LoadSceneByIndex(int index) {
        SceneManager.LoadScene(index);
    }
    
    public void LoadScene(string sceneName) {
        SceneManager.LoadScene(sceneName);
    }
    
    public void LoadScene(StringScriptableValue sceneName) {
        SceneManager.LoadScene(sceneName.Value);
    }
}
