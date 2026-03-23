using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class logicScript : MonoBehaviour
{
    public int score;
    public Text scoretext;
    public GameObject myrigidbody2;
    public GameObject gameOverscreen;
    public GameObject gameloadScreen;
    public bool gameHasStarted=false;

    private void Start()
    {
        Time.timeScale = 0;
    }
    public void Update()
    {
        if (!gameHasStarted && (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)))
        {
            StartGame();
        }
    }

    void StartGame()
    {
        gameHasStarted = true;
        gameloadScreen.SetActive(false);
        myrigidbody2.SetActive(true);
        Time.timeScale = 1;
    }




    public void Addscore(int x)
    {
        score += x;
        scoretext.text = score.ToString();
    }

    public void restartgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverscreen.SetActive(true);
    }

    public void loadScreen()
    {
        gameloadScreen.SetActive(false);
    }
}
