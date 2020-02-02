using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Extinguisher : MonoBehaviour
{
    public ParticleSystem particle;

    // Start is called before the first frame update
    void Start()
    {
        StopFiring();
    }

    // Update is called once per frame
    void Update()
    {
        //TODO touch
        if (Input.GetMouseButton(0) || Input.touchCount > 0)
        {
            StartFiring();
        }
        else
        {
            StopFiring();
        }
    }

    void StartFiring()
    {
        if (!particle.isEmitting)
        {
            particle.Play();
        }
    }

    void StopFiring()
    {
        particle.Stop();
    }
}
