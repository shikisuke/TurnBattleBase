using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //ゲームが終了したらSampleSceneを読み込み直す

// 戦いを管理する
// Player と Enemyを戦わせる

public class BattleManager : MonoBehaviour
{
    // Player を取得
    public UnitManager player;
    // Enemy を取得
    public UnitManager enemy;

    void Start()
    {
        player.Attack(enemy);
        enemy.Attack(player);

    }

    // PlayerがEnemyを攻撃
       // Button処理
    public void OnAttackButton()
    {
        player.Attack(enemy);   //playerが攻撃したら

        if (enemy.hp > 0)           //敵が生きていれば
        {
            EnemyTurn();            //次にEnemyが攻撃
        }
        else
        {
            BattleEnd();
        }

    }

    // EnemyがPlayerに攻撃
    void EnemyTurn()
    {
        enemy.Attack(player);
        if (player.hp == 0)        //hp0になったらリスタート
        {
            BattleEnd();
        }

    }

    void BattleEnd()
    {
        Debug.Log("たいありでした");
        //リスタート
        string currentScene = SceneManager.GetActiveScene().name; 
        SceneManager.LoadScene(currentScene);
    }

}