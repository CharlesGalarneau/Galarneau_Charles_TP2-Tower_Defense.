using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interface : MonoBehaviour
{
    public Button ButtonPlay;
    public Button ButtonPause;
    float Lifepoints;
    float CoinsColled;
    float ennemieskilled;
    public Text txtTimer;
    float timer;
    public Text txtvague;
    public Text txtMoney;
    public Text txtLife;
    public Text txtennemieskilled;
    public gamemanager gamemanager;
    
    // Start is called before the first frame update
    void Start()
    {
        ButtonPlay.onClick.AddListener(ButtonPlayClicked);
        ButtonPause.onClick.AddListener(ButtonPauseClicked);

        ButtonPause.gameObject.SetActive(false);

        gamemanager = GetComponent<gamemanager>();
        txtLife.text = gamemanager.PlayerLife.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        txtTimer.text = timer.ToString();
        txtTimer.text = string.Format("{0:0}:{1:00}",
                   Mathf.Floor(timer / 60),   // Minutes
                   Mathf.Floor(timer) % 60);  // seconds
         
    }
    void ButtonPlayClicked()
    {
        
        ButtonPlay.gameObject.SetActive(false);
        ButtonPause.gameObject.SetActive(true);
        
    }
    void ButtonPauseClicked()
    {
        ButtonPlay.gameObject.SetActive(true);
        ButtonPause.gameObject.SetActive(false);
    }
}
