using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatoMove : MonoBehaviour
{
    public Vector3 StartPos;
    public Vector3 EndPos;
    public float time;
    private Vector3 deltaPos;
    private float elapsedTime;
    private bool bStartToEnd = true;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = StartPos;
        deltaPos = (EndPos - StartPos) / time;
        elapsedTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += deltaPos * Time.deltaTime;
        elapsedTime += Time.deltaTime;
        if (elapsedTime > time)
        {
            if (bStartToEnd)
            {
                deltaPos = (StartPos - EndPos) / time;
                transform.position = EndPos;
            }
            else
            {
                deltaPos = (EndPos - StartPos) / time;
                transform.position = StartPos;
            }
            bStartToEnd = !bStartToEnd;
            elapsedTime = 0;
        }
    }
}
