using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{


    public int score;
    public Text scoretext;


    void Start()
    {
        score = 0;
        scoretext.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void uptadescore()
    {
        score++;
        scoretext.text = score.ToString();




    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);

    }




}
