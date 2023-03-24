using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControl : MonoBehaviour
{
    public AudioSource Tumeri;
    public AudioSource kalaChasma;
    public AudioSource zoobiDoobi;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayKalaChasma()
    {
        StopTumeri();
        StopZoobi();
        kalaChasma.Play();
    }
    public void PlayTumeri()
    {
        StopKalaChasma();
        StopZoobi();
        Tumeri.Play();
    }
    public void PlayZoobi()
    {
        StopKalaChasma();
        StopTumeri();
        zoobiDoobi.Play();
    }
    public void StopKalaChasma()
    {
        kalaChasma.Stop();
    }
    public void StopTumeri()
    {
        Tumeri.Stop();
    }
    public void StopZoobi()
    {
        zoobiDoobi.Stop();
    }
    public void StopAll()
    {
        kalaChasma.Stop();
        Tumeri.Stop();
        zoobiDoobi.Stop();
    }
}
