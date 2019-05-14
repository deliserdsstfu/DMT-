using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverObject : MonoBehaviour
{
    public GameObject gameoverplayer;
    public GameObject player;
    public GameObject camera;
    public GameObject score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameoverplayer.transform.position.x > player.transform.position.x || gameoverplayer.transform.position.y > player.transform.position.y)
        {
            Debug.Log("Game over player");
            camera.GetComponent<cameramove>().enabled = false;
            score.GetComponent<ScoreManager>().enabled = false;

        }
    }
}
