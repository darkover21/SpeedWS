
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIControllers : MonoBehaviour
{
    public static UIControllers instance;
    public CustomPanelController customPanelController;
    public GameObject menuPanel;
    public GameObject settingsPanel;
    public GameObject themesPanel;
    public GameObject mainPanel;

    

    private void Awake()
    {
        // Check if instance already exists
        if (instance == null)

            //if not, set instance to this
            instance = this;

        // If instance already exists and it's not this:
        else if (instance != this)

            // Then destroy this           
            Destroy(gameObject);

        // Sets this to not be destroyed when reloading scene
        //DontDestroyOnLoad(gameObject);
        
    }

    void Start()
    {
        string currentScene = SceneManager.GetActiveScene().name;


        customPanelController.GoToPanel("MainMenu");
    }
}
