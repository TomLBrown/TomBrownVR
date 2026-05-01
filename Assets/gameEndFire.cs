using UnityEngine;

public class gameEndFire : MonoBehaviour
{
    public int endCounter = 6;
    public int fireCounter = 0;
    public AudioSource gameOver;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        endCounter = 6;
        fireCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(fireCounter == endCounter)
        {
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
