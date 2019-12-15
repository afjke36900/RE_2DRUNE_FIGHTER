using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfHealth : MonoBehaviour
{
    #region 血量設定

    public const float maxHealth = 100;
    public int HealthTimes = 0;
    [Header("最大血量")]
    public float currentHealth = maxHealth;//血量設定
    public RectTransform HealthBar;
    [Header("Y軸偏移值")]
    public float offsetY = 20f;
    [Header("X軸偏移值")]
    public float offsetX = 20f;
    [Header("跟隨目標")]
    public GameObject Target;//跟隨目標
    [Header("血量")]
    public GameObject Health;//血量
    public Canvas can;

    private float max;//固定長度
    #endregion

    #region 執行
    private void Start()
    {
        can = GameObject.Find("Canvas").GetComponent<Canvas>();
        Target = gameObject;
        Health = Instantiate<GameObject>(Health, can.transform);
        HealthBar = Health.GetComponent<RectTransform>();
        max = Target.GetComponent<enemy_satus>().EnemyMaxHp;
        HealthTimes = 0;
    }

    private void ChangeHealth()

    {
        if (HealthTimes == 0 && currentHealth <= 0)
        {
            HealthTimes += 1;
            currentHealth = 100;
        }
    }


    void Update()
    {
        currentHealth = Target.GetComponent<enemy_satus>().EnemyHp;
        HealthBar.sizeDelta = new Vector2(100 * currentHealth / max, HealthBar.sizeDelta.y);
        Vector2 TargeP = Camera.main.WorldToScreenPoint(Target.transform.position);
        Health.GetComponent<RectTransform>().position = TargeP + Vector2.up * offsetY + Vector2.left * offsetX;

        if (currentHealth <= 0)
        {
            ChangeHealth();
        }
        /* if (Input.GetKey(KeyCode.H))
         {
             currentHealth -= 20;
         }*/
    }
    #endregion
}
