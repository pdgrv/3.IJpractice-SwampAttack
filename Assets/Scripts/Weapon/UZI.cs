using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UZI : Weapon
{
    public override void Shoot(Transform shootPoint)
    {
        float _deltaOffset = Random.Range(-0.1f, 0.1f);
        Instantiate(Bullet, shootPoint.position + Vector3.up * _deltaOffset, Quaternion.identity);
    }
}
