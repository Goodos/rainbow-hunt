using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgainScript : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private GameObject ball;
    [SerializeField] private GameObject startAgain;
    [SerializeField] private GameObject splash;
    [SerializeField] private GameObject menuCanvas;




    public void StartAgain()
    {
        SceneManager.LoadScene(0);
    }
}
