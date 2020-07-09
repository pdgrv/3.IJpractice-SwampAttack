using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : Weapon
{
    public override void Shoot(Transform shootPoint)
    {
        for (int i = 0; i < 3; i++)
        {
            float _deltaOffset = Random.Range(-0.1f, 0.1f);
            Instantiate(Bullet, shootPoint.position + (Vector3.right/2 + Vector3.up) * _deltaOffset, Quaternion.identity);
        }
    }
}
