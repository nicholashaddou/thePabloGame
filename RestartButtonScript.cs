using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButtonScript : MonoBehaviour
{
    Checkpoint checkpoint;
    private GameMaster gameMaster;

    public void restartScene()
    {
        SceneManager.LoadScene("JuanGame");
    }
}
