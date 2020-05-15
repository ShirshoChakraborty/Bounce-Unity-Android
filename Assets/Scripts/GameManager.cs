using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private const string V = "Cool";
    public static GameManager instance;
    private int score;
    public GameObject gameStartUI;

    public Text scoreText;


    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
        Debug.Log("Restarted");

    }

    public void ScoreUp()
    {
        score++;

        Debug.Log("Score up: " + score);
        scoreText.text = score.ToString();
    }

    public void gameStart()
    {
        gameStartUI.SetActive(false);
        scoreText.gameObject.SetActive(true);
    }
}
