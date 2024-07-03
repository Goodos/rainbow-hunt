using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class MenuScreen : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject playScreen;
    [SerializeField] private GameObject menuScreen;
    [SerializeField] private GameObject ball;
    [SerializeField] private bool isItTest;
    [SerializeField] private AudioSource music;

    private bool death;

    void Start()
    {
        death = false;
        switch (PlayerPrefs.GetInt("MuteMusic"))
        {
            case 1:
                music.mute = true;
                break;

            case 0:
                music.mute = false;
                break;
        }
    }

    public void Death()
    {
        death = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!death)
        {
            switch (isItTest)
            {
            case true:

                if (Input.GetMouseButton(0))
                {

                    playScreen.SetActive(true);
                    ball.SetActive(true);
                    menuScreen.SetActive(false);
                }
                break;

            case false:
                if (Input.touchCount>0)
                {
                    ball.SetActive(true);
                    playScreen.SetActive(true);
                    menuScreen.SetActive(false);
                }
                break;

            }
        }
        

        
    }
}
