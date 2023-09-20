using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TimerBehaviour : MonoBehaviour
{
    private float time;
    private float endtime;
    public float InitialTime;
    public bool countDown;
    public float timeout;
    public UnityEvent<float> Ontime;
    public UnityEvent OnTimeOut;
    // Start is called before the first frame update
    void Start()
    {
        RestartTime();
    }

    public void RestartTime()
    {
        time = InitialTime;
        Ontime.Invoke(time);
        timeout = 1;
    }
    public void StopTime()
    {
        timeout = 0;
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(timeout == 1)
        {
            if (countDown)
            {
                time -= Time.deltaTime;
                if (time <= 0)
                    OnTimeOut.Invoke();
            }
            else
            {
                time += Time.deltaTime;
                
            }
            Ontime.Invoke(time);
        }
        
    }
}
