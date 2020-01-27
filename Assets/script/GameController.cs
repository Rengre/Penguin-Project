using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Camera cam;
    public GameObject fish;
    public GameObject orca;
    public GameObject penguin;
    public GameObject[] platform;
    private Rigidbody2D rb;
    private Renderer fishRenderer;
    public GameObject startScreen;
    public GameObject startButton;
    public GameObject arrowup;
    public GameObject arrowdown;
    public GameObject txtmvup;
    public GameObject txtmvdown;
    public GameObject space;
    public GameObject miscoff;
    public GameObject text;
    public GameObject soundbtn;
    float tempspeedF = 5.0f;
    float tempspeedO = 5.0f;
    float tempspeedP = 5.0f;
    int randPlatform;
    int tempScore=0;
    int tempScoreO = 0;
    void Start()
    {
        if (cam == null)
        {
            cam = Camera.main;
        }
    }
    public void StartGame()
    {
        startScreen.SetActive(false);
        startButton.SetActive(false);
        arrowdown.SetActive(false);
        space.SetActive(false);
        miscoff.SetActive(false);
        text.SetActive(false);
        arrowup.SetActive(false);
        space.SetActive(false);
        txtmvdown.SetActive(false);
        txtmvup.SetActive(false);
        soundbtn.SetActive(true);
        StartCoroutine(SpawnFish());
        StartCoroutine(SpawnOrca());
        StartCoroutine(SpawnPlatform());
    }
    IEnumerator SpawnFish()
    {
        yield return new WaitForSeconds(1.0f);
        while (true)
        {
            Vector3 spawnPosition = new Vector3(
                transform.position.x,
                Random.Range(-4, -10),
                0.0f
                );
            Quaternion spawnRotation = Quaternion.identity;
            GameObject tempFish = (GameObject)Instantiate(fish, spawnPosition, spawnRotation);
            if (penguin.GetComponent<score>().Score % 5 == 0 && 
                    tempScore != penguin.GetComponent<score>().Score &&
                    penguin.GetComponent<score>().Score > 0)
            {
                tempScore =penguin.GetComponent<score>().Score ;
                tempspeedF *= 1.3f;
            }
                
            tempFish.GetComponent<fishmove>().speed = tempspeedF;
            yield return new WaitForSeconds(Random.Range(1.0f, 2.0f));
        }
    }
    IEnumerator SpawnOrca()
    {
        yield return new WaitForSeconds(7.0f);
        while (true)
        {
            Vector3 spawnPosition = new Vector3(
                transform.position.x,
                Random.Range(-4, -10),
                0.0f
                );
            Quaternion spawnRotation = Quaternion.identity;
            GameObject tempOrca = (GameObject)Instantiate(orca, spawnPosition, spawnRotation);
            if (penguin.GetComponent<score>().Score % 5 == 0 && tempScoreO != penguin.GetComponent<score>().Score && penguin.GetComponent<score>().Score > 0)
            {
                tempScoreO = penguin.GetComponent<score>().Score;
                tempspeedO *= 1.3f;
            }
            tempOrca.GetComponent<fishmove>().speed = tempspeedO;
            yield return new WaitForSeconds(Random.Range(3.0f, 7.0f));
        }
    }
    IEnumerator SpawnPlatform()
    {
        yield return new WaitForSeconds(1.0f);
        while (true)
        {
            Vector3 spawnPosition = new Vector3(
                 transform.position.x,
                Random.Range(-3, -3),
                0.0f
                );
            Quaternion spawnRotation = Quaternion.identity;
            randPlatform = Random.Range(0, platform.Length);
            Instantiate(platform[randPlatform], spawnPosition, spawnRotation);
            yield return new WaitForSeconds(Random.Range(3.0f, 7.0f));
        }
    }
}
