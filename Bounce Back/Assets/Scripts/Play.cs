using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("MainGame"); // Make sure "MainGame" is the exact name of your scene
    }
}
