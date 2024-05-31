using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void ChangeSceneTo(string SceneToLoad)
    {
        SceneManager.LoadScene(SceneToLoad);
    }
}
