using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK.Examples;

public class PistolaDeMano : GunShoot
{
    public Animator anim;
    public GameObject flashPrefab;
    public AudioClip sonidoDisparo;

  protected override void FireProjectile()
    {
        base.FireProjectile();
        anim.SetTrigger("Fire");
        var muzzleFlash = Instantiate(flashPrefab,
            projectileSpawnPoint.position,
            projectileSpawnPoint.rotation);
        Destroy(muzzleFlash, 0.3f);

        AudioSource.PlayClipAtPoint(sonidoDisparo, transform.position);
    }
}
