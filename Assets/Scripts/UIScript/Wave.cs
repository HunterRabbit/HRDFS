using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour
{
    public float shakeTime = 0.1f;
    public float shakeSpeed = 2.0f;
    public float shakeAmount = 1.0f;

    public Transform Object;

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    public void Lie()
    {
        StartCoroutine(Shake());
    }

    IEnumerator Shake()
    {
        Vector3 originPosition = Object.localPosition;
        float elapsedTime = 0.0f;

        while (elapsedTime < shakeTime)
        {
            Vector3 randomPoint = originPosition + Random.insideUnitSphere * shakeAmount;
            Object.localPosition = Vector3.Lerp(Object.localPosition, randomPoint, Time.deltaTime * shakeSpeed);

            yield return null;

            elapsedTime += Time.deltaTime;
        }

        Object.localPosition = originPosition;
    }
}
