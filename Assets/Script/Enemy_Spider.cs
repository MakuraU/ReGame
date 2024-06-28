using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy_Spider : MonoBehaviour
{
    public int EnemyHp = 50;
    public GameObject damageUI;
    public bool hasTakenDamage = false;

    void Start()
    {

    }

    void Update()
    {
        if (EnemyHp <= 0)
        {
            if (this.gameObject.tag == "Enemy")
            {
                ShopManager.Gill += 100;
            }if (this.gameObject.name == "Black Widow")
            {
                CreatManager.Wood += 10;
            }
            Destroy(this.gameObject);
        }
    }

    public void Damage(Collider col)
    {
        var obj = Instantiate<GameObject>(damageUI, col.bounds.center - Camera.main.transform.forward * 0.2f, Quaternion.identity);
        obj.GetComponentInChildren<Text>().text = ("" + Sword.damageValue); // 确保每次显示正确的伤害值
    }
}
