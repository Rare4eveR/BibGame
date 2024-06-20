using System.Diagnostics.Tracing;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private string state = "Start";
    private string state2 = "Pause";
    private float timer;
    private float maxTime = 30f;
    public int score = 0;

    public GameObject pause;

    public static float playerHealth = 100f;
    public static float playerMana = 100f;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        if (state == "Game")
        {
            timer += Time.deltaTime;
            if (timer >= maxTime)
            {
                ReturnToTitle();
      
            }
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {

            if (pause.activeSelf)
            {
            pause.SetActive(false);
                Time.timeScale = 1f;
            }
            else
            {
            pause.SetActive(true);
                Time.timeScale = 0f;
            }
            //pause.SetActive(!pause.activeSelf);
        }

    }

    public void Play()
    {
        SceneManager.LoadScene("Game");
        state = "Game";
        timer = 0;
    }

    public void NewGame()
    { 
        score = 0;
        timer = 0;
        playerHealth = 100f;
        Play();

    }

    public void Exit()
    {
        Application.Quit();
    }

    public void ReturnToTitle()
    {
        SceneManager.LoadScene("StartScreen");
        state = "Start";
        timer = 0; 
    }
}
