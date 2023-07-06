using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchAnimation : MonoBehaviour
{
    Animator animator;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            StartCoroutine(SetFlag("mtn_02"));
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            StartCoroutine(SetFlag("mtn_03"));
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            StartCoroutine(SetFlag("mtn_04"));
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            StartCoroutine(SetFlag("special_01"));
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            StartCoroutine(SetFlag("special_02"));
        }
    }

    public IEnumerator SetFlag(string flagName)
    {
        animator.SetBool(flagName, true);
        yield return new WaitForEndOfFrame();
        animator.SetBool(flagName, false);
    }
}