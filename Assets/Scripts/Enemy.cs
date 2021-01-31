using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnemyState
{
    idle,
    walk,
    attack,
    stagger
}
public class Enemy : MonoBehaviour
{
    [Header("Animator")]
    public Animator anim;

    [Header("State Machine")]
    public EnemyState currentState;

    [Header("Enemy Stats")]
    public FloatValue maxHealth;
    public float health;
    public string enemyName;
    public int baseAttack;
    public float moveSpeed;
    

    private void Awake()
    {
        health = maxHealth.initialValue;
    }
    private void OnEnable()
    {
        health = maxHealth.initialValue;
        currentState = EnemyState.idle;
    }
    public void TakeDamage(float damage)

    {
        health -= damage;

        if (health <= 0)
        {
            anim.SetBool("death", true);
            Destroy(this.gameObject, 1f);
        }
    }
    
    public void Knock(Rigidbody2D myRigidbody, float knockTime, float damage)
    {
        StartCoroutine(knockCo(myRigidbody, knockTime));
        TakeDamage(damage);
    }
    private IEnumerator knockCo(Rigidbody2D myRigidbody, float knockTime)
    {
        if (myRigidbody != null)
        {
            yield return new WaitForSeconds(knockTime);
            myRigidbody.velocity = Vector2.zero;
            currentState = EnemyState.idle;
            myRigidbody.velocity = Vector2.zero;
        }
    }
}
