using UnityEngine;

public class AppManager : MonoBehaviour {

    [SerializeField] private int targetFPS = 60;

    private void Awake() {
        Application.targetFrameRate = targetFPS;
    }
}
