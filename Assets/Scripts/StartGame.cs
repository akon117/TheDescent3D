using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public void begin()
    {
        StartCoroutine(StartGameCo());
    }

    IEnumerator StartGameCo()
    {
        GameObject.Find("Main Camera").GetComponent<CameraFadeOut>().fadeOut = true;
        yield return new WaitForSeconds(2);
        GameObject.Find("EventSystem").GetComponent<LoadNextScene>().LoadScene("SampleScene");
    }
}
