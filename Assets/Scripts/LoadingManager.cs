using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingManager : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
            SceneManager.LoadScene(2);
        if (Input.GetKeyDown(KeyCode.P))
            SceneManager.LoadScene(3);
        if (Input.GetKeyDown(KeyCode.L))
            SceneManager.LoadScene(4);
    }
}