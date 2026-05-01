using UnityEngine;

public class gameEndFire : MonoBehaviour
{
    public int endCounter = 6;
    public int fireCounter = 0;
    public GameObject allFires;
    public AudioSource gameOver;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        allFires.SetActive(false);
        endCounter = 6;
        fireCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(fireCounter == endCounter)
        {
            allFires.SetActive(true);
            gameOver.Play();
            Invoke("GameEnd", 10);
        }
    }

    void GameEnd()
    {
        Application.Quit();
        Debug.Log("Game has quit");
    }
}
