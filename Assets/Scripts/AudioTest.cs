using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class AudioTest : MonoBehaviour
{
    List<GameObject> audioSources = new List<GameObject>();
    UnityEngine.Random random = new Random();

    private void Start()
    {
        // 私のDiscord のIDです！ こちらの方がやり取りが楽だと思うので。
        // ID : oohiramao
        audioSources.Add(GameObject.Find("AudioSource1"));
        audioSources.Add(GameObject.Find("AudioSource2"));
        audioSources.Add(GameObject.Find("AudioSource3"));
    }


    bool played = true;
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.A) && played)
        {
            StartCoroutine(PlayAudio());
        }
    }


    IEnumerator PlayAudio()
    {
        played = false;

        GameObject source = audioSources[Random.Range(0, audioSources.Count)];
        source.SetActive(true);

        foreach (var a in audioSources)
        {
            if (a != source)
            {
                a.SetActive(false);
            }
        }

        yield return new WaitForSeconds(0.7f);
        source.SetActive(false);
        
        played = true;
    }
}
