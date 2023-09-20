using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{

    public AudioClip[] songs;
    private AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }


    /* public void HurtSound()
    {
        audio.clip = songs[0];
        audio.Play();
    } */
    
    public void CoinSound()
    {
        audio.clip = songs[0];
        audio.Play();
    }

    /* public void EndGame()
    {
        audio.clip = songs[1];
        audio.Play();
    } */

    public void Die()
    {
        audio.clip = songs[1];
        audio.Play();
    } 
    public void OpenDoor()
    {
        audio.clip = songs[2];
        audio.Play();
    } 

    public void StopPlay()
    {
        audio.Stop();
    }

}
