using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//キャラクターを管理する
public class UnitManager : MonoBehaviour
{
    //ステータス
    public int hp;
    public int at;

    // 攻撃関数
    public void Attack(UnitManager target)  //かっこ内は攻撃相手が入る
    {
        target.Damage(at);
    }

    //ダメージ関数
    void Damage(int damage)
    {
        hp -= damage;
        Debug.Log(name +"は"+damage+ "ダメージを受けた");

        if (hp <= 0)
        {
            hp = 0;
            Debug.Log("戦闘不能");
        }


    }
}

