using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Descend : MonoBehaviour
{
    public Camera mainCamera;
    public GameObject player;
    public TextMeshProUGUI descendText;
    public int check = 0;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && descendText.text == "Press 'E' to Descend")
        {
            descendText.text = "";
            check++;
            if(check == 1)
            {
                player.GetComponent<Movement>().enabled = false;
                mainCamera.GetComponent<CameraFadeOut>().fadeOut = true;
                StartCoroutine(LoadLadder());
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            descendText.text = "Press 'E' to Descend";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            descendText.text = "";
        }
    }

    IEnumerator LoadLadder()
    {
        yield return new WaitForSeconds(5);
        //GameObject.Find("GameManager").GetComponent<GameManager>().GoToLadder();
        GameObject.Find("GameManager").GetComponent<LoadNextScene>().LoadScene("Ladder");
    }

}