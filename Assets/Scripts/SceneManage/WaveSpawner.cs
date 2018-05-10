using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour {

    public Transform enemyPrefab;
    public Transform[] spawnPoints;
    public Text waveCountdownText;
    public Text waveCountText;
    public GameObject warningText;
    public GameObject countdownText;

    public float timeBetweenWaves;
    private float countdown = 5f;
    private int waveIndex = 0;

    private void Start()
    {
        countdownText.SetActive(true);
    }

    void Update()
    {
        if(countdown <= 0f)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
            
        }
        countdown -= Time.deltaTime;
        waveCountdownText.text = Mathf.Floor(countdown).ToString();
        waveCountText.text = waveIndex.ToString();

    }

    IEnumerator SpawnWave()
    {
        waveIndex++;
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            countdownText.SetActive(false);
            warningText.SetActive(true);
            for (int j = 0; j < waveIndex; j++)
            {
                Instantiate(enemyPrefab, spawnPoints[i].position, spawnPoints[i].rotation);
                yield return new WaitForSeconds(0.5f);
            }
        }
        countdown = timeBetweenWaves;
        warningText.SetActive(false);
        countdownText.SetActive(true);
        if (waveIndex % 3 == 0)
        {
            FindObjectOfType<GameManager>().DropReward();
        }
    }
}
