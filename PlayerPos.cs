using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPos : MonoBehaviour
{
    private GameMaster gameMaster;

    private void Start()
    {
        gameMaster = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        transform.position = gameMaster.lastCheckPoint;
    }

    private void Update()
    {
        SetRestartPoint();
    }

    public void SetRestartPoint()
    {
        if (gameObject.CompareTag("KillZone") || (gameObject.CompareTag("Enemy")))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
