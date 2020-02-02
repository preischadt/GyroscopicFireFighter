using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    float maxLife = 0.5f;
    float currentLife;
    public ParticleSystem particle;

    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnParticleCollision(GameObject other)
    {
        currentLife -= Time.deltaTime;
        Debug.Log($"Collision: {currentLife}");

        for (int i = 0; i < transform.childCount; i++)
        {
            if (currentLife <= i * maxLife / transform.childCount)
            {
                transform.GetChild(i).gameObject.SetActive(false);
            }
        }
    }

    void Spawn()
    {
        currentLife = maxLife;
    }
}
