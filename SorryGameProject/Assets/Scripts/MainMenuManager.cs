using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class MainMenuManager : MonoBehaviour
{

    public static int howManyPlayers;
    public void TwoPlayers()
    {
        //SoundManager.buttonAudioSource.play();
        howManyPlayers = 2;
        // SceneManager.LoadScene("GameScene");
    }

    public void ThreePlayers()
    {
        //SoundManager.buttonAudioSource.play();
        howManyPlayers = 3;
        SceneManager.LoadScene("GameScene");
    }

    public void FourPlayers()
    {
        //SoundManager.buttonAudioSource.play();
        howManyPlayers = 4;
        SceneManager.LoadScene("GameScene");
    }
    public void Quit()
    {
        //SoundManager.buttonAudioSource.play();
        if (EditorApplication.isPlaying == true)
        {
            EditorApplication.isPlaying = false;
        }
    }

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }
}
