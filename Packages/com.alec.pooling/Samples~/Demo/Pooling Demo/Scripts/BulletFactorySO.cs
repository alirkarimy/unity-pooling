﻿using UnityEngine;
using UOP1.Factory;

[CreateAssetMenu(fileName = "NewBulletFactory", menuName = "Factory/Bullet Factory")]
public class BulletFactorySO : FactorySO<GameObject>
{
    public GameObject Bullet;
    public override GameObject Create()
    {
        return Instantiate(Bullet);
    }
}
