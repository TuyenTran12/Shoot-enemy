using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject btnRestartGame;
    public GameObject txtLoseGame;
    GameController m_gameController;
    // Start is called before the first frame update
    void Start()
    {
        btnRestartGame.SetActive(false);
        txtLoseGame.SetActive(false);
        m_gameController = FindObjectOfType<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(m_gameController.isEndGame == true)
        {
            btnRestartGame.SetActive(true);
            txtLoseGame.SetActive(true);
        }
    }
    public void Reset()
    {
        SceneManager.LoadScene(0);
    }
}
