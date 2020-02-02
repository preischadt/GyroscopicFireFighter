using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    float maxLife = 0.5f;
    float currentLife;
    private static int liveFires = 0;
    private Collider col;
    public GameObject firePrefab;
    private int totalChilds = 5;

    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<Collider>();

        RunSpawn();
    }

    void OnParticleCollision(GameObject other)
    {
        currentLife -= Time.deltaTime;

        int childIndex = transform.childCount;
        if(currentLife <= childIndex * maxLife / totalChilds)
        {
            Destroy(transform.GetChild(0).gameObject);
            if (childIndex == 0)
            {
                Die();
            }
        }
    }

    void Spawn()
    {
        col.enabled = true;
        liveFires++;
        currentLife = maxLife;
        for (int i = 0; i < totalChilds; i++)
        {
            Instantiate(firePrefab, transform);
        }
    }

    void Die()
    {
        liveFires--;
        col.enabled = false;
        RunSpawn();
    }

    IEnumerator SpawnAfterSeconds()
    {
        yield return new WaitForSeconds(Random.value*20f);
        Spawn();
    }

    void RunSpawn()
    {
        StartCoroutine(SpawnAfterSeconds());
    }
}
