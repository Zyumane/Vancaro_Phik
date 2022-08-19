using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameDifference : MonoBehaviour
{
    public int frameToShow = 60;

    protected int updateCall = 0;
    protected int fixedUpdateCalls = 0;

    void Start()
    {
        Application.targetFrameRate = frameToShow;
    }

    void Update()
    {
        fixedUpdateCalls = 0;
        updateCall++;
        Debug.Log("Update: " + updateCall + " llamada/s");
    }

    void FixedUpdate()
    {
        updateCall = 0;
        fixedUpdateCalls++;
        Debug.Log("Fixed Update: " + fixedUpdateCalls + " llamada/s");

    }
}
