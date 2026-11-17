using UnityEngine;

public class MysticMenuController : MonoBehaviour
{
    [Header("Menu Panels")]
    public GameObject mainMenu;
    public GameObject customizeMenu;
    public GameObject settingsMenu;
    public GameObject creditsMenu;

    public void Play()
    {
        Debug.Log("Entering Mystic Tag lobby!");
    }

    public void Customize()
    {
        ShowPanel(customizeMenu);
    }

    public void Settings()
    {
        ShowPanel(settingsMenu);
    }

    public void Credits()
    {
        ShowPanel(creditsMenu);
    }

    public void BackToMain()
    {
        ShowPanel(mainMenu);
    }

    void ShowPanel(GameObject panel)
    {
        if (mainMenu != null) mainMenu.SetActive(false);
        if (customizeMenu != null) customizeMenu.SetActive(false);
        if (settingsMenu != null) settingsMenu.SetActive(false);
        if (creditsMenu != null) creditsMenu.SetActive(false);

        if (panel != null) panel.SetActive(true);
    }
}
