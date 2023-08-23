using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    private Custominput input = null;

    private void Awake()
    {
        input = new Custominput();

    }

    private void OnEnable()
    {
        input.Enable();

    }

    private void OnDisable()
    {
        input.Disable();
    }
}
