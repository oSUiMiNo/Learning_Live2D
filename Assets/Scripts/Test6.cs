using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test6 : MonoBehaviour
{
    [SerializeField] Slider slider;
    [SerializeField] GameObject mao;
    [SerializeField] GameObject u;

    private void Update()
    {
        if(slider.value > 0.5)
        {
            u.SetActive(true);
            mao.SetActive(false);
        }
        else
        {
            mao.SetActive(true);
            u.SetActive(false);
        }
    }

    
}
