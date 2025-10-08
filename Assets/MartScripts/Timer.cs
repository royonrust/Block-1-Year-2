using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Primitives;

public class Timer : MonoBehaviour
{
    public Slider breathSlider;

    private float sliderTimer = 60.0f;

    public bool stopTimer = false;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        breathSlider.maxValue = sliderTimer;
        breathSlider.value = sliderTimer;
        StartTimer();
    }

    // Update is called once per frame
    public void StartTimer()
    {
        StartCoroutine(StartBreathHold());

    }

    private void OnLevelWasLoaded(int level)
    {
        //set player position to (0,0,0), can add a gameobject with serialisefield
    }

    IEnumerator StartBreathHold()
    {
        while (stopTimer == false)
        {
            sliderTimer -= Time.deltaTime;

            if (sliderTimer <= 0 ) 
            {
                stopTimer = true;
                if ( stopTimer)
                {
                    SceneManager.LoadScene(4);
                }
            }

            if (stopTimer == false) 
            { 
                breathSlider.value = sliderTimer;
            }

            yield return new WaitForSeconds(0.001f);
        }
    }

}
