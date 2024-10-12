using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoulatteManager : MonoBehaviour
{
    public GameObject roulette;
     public float rotatePerRoulette;

    private string result;
    private float rouletteSpeed;
    private float slowDownSpeed;
    private int frameCount;
    private bool isPlaying;
    public GameObject RoCuso;
   static public bool isStop;
    [SerializeField] private Text resultText;
    [SerializeField] private Button startButton;
    [SerializeField] private Button stopButton;
  

    public void SetRoulette()
    {
        isPlaying = false;
        isStop = false;
        startButton.gameObject.SetActive(true);
        stopButton.gameObject.SetActive(false);
       
        startButton.onClick.AddListener(StartOnClick);
        stopButton.onClick.AddListener(StopOnClick);
      
    }

    private void Update()
    {
        if (!isPlaying) return;
        roulette.transform.Rotate(0, rouletteSpeed, 0);
        frameCount++;
        if (isStop && frameCount > 3)
        {
            rouletteSpeed *= slowDownSpeed;
            slowDownSpeed -= 0.25f * Time.deltaTime;
            frameCount = 0;
        }
        if (rouletteSpeed < 0.05f)
        {
            isPlaying = false;
            ShowResult(roulette.transform.eulerAngles.z);
        }
    }

    public void StartOnClick()
    {
        rouletteSpeed = 14f;
        startButton.gameObject.SetActive(false);
        Invoke("ShowStopButton", 1.5f);
        isPlaying = true;
    }

    public void StopOnClick()
    {
        slowDownSpeed = Random.Range(0.92f, 0.98f);
        isStop = true;
        stopButton.gameObject.SetActive(false);
        Invoke("ShowResult", 3f);
    }


    private void ShowStopButton()
    {
        stopButton.gameObject.SetActive(true);
    }

    private void ShowResult(float x)
    {
        RoCuso.SetActive(true);


    }
}
