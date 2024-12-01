using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class UIFunctionality : MonoBehaviour
{
    public TMP_InputField playerName;
    public Button startButton;
    public Button QuitButton;

    private StartMenuManager startMenuManager;

    private void Start()
    {
        startMenuManager = GameObject.Find("StartMenuManager").GetComponent<StartMenuManager>();
        startButton.onClick.AddListener(StartGame);
        QuitButton.onClick.AddListener(QuitGame);
    }

    public void StartGame()
    {
        Debug.Log("Player Name Entered: " + playerName.text);
        startMenuManager.UserName(playerName.text);
        SceneManager.LoadScene("main");
    }

    public void QuitGame()
    {
        Debug.Log("Application Quit!");
        Application.Quit();
    }
}
