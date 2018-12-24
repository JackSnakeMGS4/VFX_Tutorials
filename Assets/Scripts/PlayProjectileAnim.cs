using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayProjectileAnim : MonoBehaviour
{
    [SerializeField] GameObject mainProjectile;
    [SerializeField] ParticleSystem mainPS;

    // Update is called once per frame
    void Update()
    {
        if(mainProjectile != null && mainPS != null)
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                mainProjectile.SetActive(true);
            }

            if (!mainPS.IsAlive())
            {
                mainProjectile.SetActive(false);
            }
        }
    }
}
