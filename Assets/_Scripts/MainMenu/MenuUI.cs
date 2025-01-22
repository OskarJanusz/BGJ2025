using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUI : MonoBehaviour
{
    [SerializeField] private Button PlayButton;
    [SerializeField] private Button HowToPlayButton;
    [SerializeField] private Button QuitButton;
    [SerializeField] private Button BackButton;
    [SerializeField] private Button PlayJury;
    private void Start()
    {
        PlayButton.onClick.AddListener(StartGame);
        HowToPlayButton.onClick.AddListener(HowToPlayScene);
        QuitButton.onClick.AddListener(QuitGame);
        BackButton.onClick.AddListener(GoBack);
        PlayJury.onClick.AddListener(PlayAsJury);
    }

    private void QuitGame()
    {
        Application.Quit();
    }

    private void StartGame()
    {
        SceneManager.LoadScene("Lvl_01");
    }

    private void HowToPlayScene()
    {
        SceneManager.LoadScene("HowToPlay");
    }

    public void GoBack()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void PlayAsJury()
    {
        SceneManager.LoadScene("Lvl_01_J");
    }
}
