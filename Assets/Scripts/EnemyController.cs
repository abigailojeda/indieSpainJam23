using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class EnemyController : MonoBehaviour
{

    [SerializeField] private Transform[] points;
    [SerializeField] private GameObject[] enemyPrefabs;
    [SerializeField] private List<GameObject> enemiesInScene = new List<GameObject>();
    [SerializeField] private float tiempoEnemigos;

    private float nextEnemyTime;
    private int totalEnemies = 0;

    private void Update()
    {
        if (totalEnemies < 5)
        {
            nextEnemyTime += Time.deltaTime;
            if (nextEnemyTime >= tiempoEnemigos)
            {
                nextEnemyTime = 0;
                generateEnemy();
            }
        }
        RegenerateEnemy();
    }

    private void generateEnemy()
    {
        int numeroEnemigo = Random.Range(0, enemyPrefabs.Length);
        int index = Random.Range(0, points.Length);

        Vector2 posicionAleatoria = new Vector2(points[index].transform.position.x, (points[index].transform.position.y));

        GameObject newEnemy = Instantiate(enemyPrefabs[numeroEnemigo], posicionAleatoria, Quaternion.identity);
        newEnemy.SetActive(true);
        enemiesInScene.Add(newEnemy);
        totalEnemies++;
    }

    void RegenerateEnemy()
    {
        enemiesInScene.ForEach(enemy =>
        {
            if(enemy.gameObject.CompareTag("Enemy"))
                totalEnemies--;
        });
    }



}
