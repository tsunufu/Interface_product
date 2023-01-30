using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // 敵関係のゲームオブジェクトをアタッチする配列
    public GameObject[] Enemys;
    // プレイヤー関係のゲームオブジェクトをアタッチする配列
    public GameObject[] Players;

    private int damage;

    /// <summary>
    /// Player側の攻撃を行う際に呼び出すメソッド
    /// </summary>
    public void PlayerAttack()
    {
        var damagetarget = Enemys[Random.Range(0, Enemys.Length)].GetComponent<IDamagable>();

        if (damagetarget != null)
        {
            damagetarget.AddDamage(damage);
        }
    }

    /// <summary>
    /// Enemy側の攻撃を行う際に呼び出すメソッド
    /// </summary>
    public void EnemyAttack()
    {
        var damagetarget = Players[Random.Range(0, Players.Length)].GetComponent<IDamagable>();

        if (damagetarget != null)
        {
            damagetarget.AddDamage(damage);
        }
    }

    /// <summary>
    /// プレイヤーを回復させる際に呼び出すメソッド
    /// </summary>
    public void PlayerHeal()
    {
        foreach(GameObject player in Players)
        {
            var healtarget = player.GetComponent<IHealable>();

            if (healtarget != null)
            {
                healtarget.AddHp(10);
            }

        }
    }
}
