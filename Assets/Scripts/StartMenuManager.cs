using UnityEngine;

public class StartMenuManager : MonoBehaviour
{
    public static StartMenuManager Instance;
    public string playerName = "";

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void UserName(string name)
    {
        StartMenuManager.Instance.playerName = name;
    }
}
