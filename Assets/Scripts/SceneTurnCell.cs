using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneTurnCell : MonoBehaviour
{
    public string name;
    public int time;
    void Start()
    {
        StartCoroutine(NewScene(name, time));
    }

    void Update()
    {
    }

    IEnumerator NewScene(string name, int time)
    {
        yield return new WaitForSeconds(time);
        Application.LoadLevel(name);
    }
}
