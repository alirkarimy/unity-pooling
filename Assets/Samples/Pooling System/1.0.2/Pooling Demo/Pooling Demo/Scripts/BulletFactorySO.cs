using UnityEngine;
using Alec.Factory;

[CreateAssetMenu(fileName = "NewBulletFactory", menuName = "Factory/Bullet Factory")]
public class BulletFactorySO : FactorySO<GameObject>
{
    public GameObject Bullet;
    public override GameObject Create()
    {
        return Instantiate(Bullet);
    }
}
