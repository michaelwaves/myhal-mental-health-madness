using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuProjectileSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] drugs;
    [SerializeField] private float waitSeconds;

    void Start()
    {
        StartCoroutine(MenuSpawn());

    }

    private IEnumerator MenuSpawn()
    {
        while (true)
        {
            var position = transform.position;
            GameObject drug = Instantiate(drugs[Random.Range(0, drugs.Length)], position, Quaternion.identity);
            yield return new WaitForSeconds(waitSeconds);
            Destroy(drug, 12f);
        }
    }

    
}
