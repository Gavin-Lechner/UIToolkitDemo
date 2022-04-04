using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
public class UIController : MonoBehaviour
{
    public Button play;
    public Button quit;
    public Label title;
    // Start is called before the first frame update
    void Start()
    {
        VisualElement Menu = GetComponent<UIDocument>().rootVisualElement;

        play = Menu.Q<Button>("PlayGame");
        quit = Menu.Q<Button>("QuitGame");
        title = Menu.Q<Label>("Title");

        play.clicked += delegate { ChangeScene("Game"); };
        quit.clicked += QuitGame;
        play.tooltip = "Test Tooltip";
    }

    void ChangeScene(string scene)
    {
        title.text = scene + " Loaded";
        SceneManager.LoadScene("Game");
    }

    void QuitGame()
    {
        Application.Quit();
        title.text = "Application Quit";
    }
}
