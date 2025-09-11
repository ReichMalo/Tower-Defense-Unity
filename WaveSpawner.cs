using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class WaveSpawner : MonoBehaviour
{
    [SerializeField]
    private Transform enemyPrefab;
    [SerializeField]
    private float timeBetweenWaves = 5.5f;
    private float countdown = 2f;
    private int waveIndex = 0;
    [SerializeField]
    private Transform spawnPoint;
    [SerializeField]
    private TextMeshProUGUI waveCountDownTimer; // UI Text to display countdown

    void Update()
    {
        if (countdown <= 0f)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves; //5s avant la prochaine vague

        }

        countdown -= Time.deltaTime; //à chaque seconde qui passe on enléve 1 seconde
        waveCountDownTimer.text = Mathf.Round(countdown).ToString();
    }

    IEnumerator SpawnWave()
    {
        waveIndex++;

        Debug.Log("Wave incoming!");
        for (int i = 0; i < waveIndex; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.5f); //délai entre chaque spawn

        }

    
    }
    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
