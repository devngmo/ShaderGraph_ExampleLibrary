using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSwitcher : MonoBehaviour
{
    public Transform camFrontPos;
    public Transform camTopPos;

    public TestCaseSettings[] testcases;
    private int curTestIdx = 0;
    // Start is called before the first frame update
    void Start()
    {
        loadCurrentTestcase();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void switchNextTest()
    {
        curTestIdx++;
        if (curTestIdx >= testcases.Length)
            curTestIdx = 0;

        loadCurrentTestcase();
    }

    private void loadCurrentTestcase()
    {
        for(int i = 0; i < testcases.Length; i++)
        {
            if (i != curTestIdx)
            {
                testcases[i].gameObject.SetActive(false);
            }
            else
            {
                testcases[i].gameObject.SetActive(true);
            }
        }
    }

    public void useCameraTop()
    {
        copyTransform(camTopPos.transform, Camera.main.transform);
        
    }

    private void copyTransform(Transform src, Transform dst)
    {
        dst.localPosition = src.localPosition;
        dst.localRotation = src.localRotation;
        dst.localScale = src.localScale;
    }

    public void useCameraFront()
    {
        copyTransform(camFrontPos, Camera.main.transform);
    }
}
