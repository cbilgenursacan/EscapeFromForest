using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sfx : MonoBehaviour
{
    public AudioSource source;
    public AudioSource bgSource;
    public AudioClip coin, barrel, barrier, finish, gameOver, bgMusic;

    private void Start()
    {
        bgSource.clip = bgMusic;
        bgSource.Play();
    }
    public void Barrel()
    {
        source.clip = barrel;
        source.Play();
    }

    public void Coin()
    {
        source.clip = coin;
        source.Play();
    }

    public void Barrier()
    {
        source.clip = barrier;
        source.Play();
    }

    public void Finish()
    {
        source.clip = finish;
        source.Play();
    }

    public void GameOver()
    {
        source.clip = gameOver;
        source.Play();
    }
}
