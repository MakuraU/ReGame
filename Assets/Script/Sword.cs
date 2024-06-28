using System.Collections;
using UnityEngine;

public class Sword : MonoBehaviour
{
    public GameObject PlayerOb;
    public bool Skill1 = false;
    public bool Skill2 = false;
    public bool Skill3 = false;
    private bool isExitingTrigger = false;

    static public int damageValue = 100;
    private Animator animator;
    private Coroutine damageCoroutine; // ダメージコルーチンを追跡するための変数
    private bool isTiming = false;

    void Start()
    {
        animator = PlayerOb.transform.root.GetComponent<Animator>();
    }

    void Update()
    {
        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);

        if (stateInfo.IsName("Attack1"))
        {
            damageValue = 100;
        }
        else if (stateInfo.IsName("Attack2"))
        {
            damageValue = 200;
        }
        else if (stateInfo.IsName("Attack3"))
        {
            damageValue = 300;
        }
        else if (stateInfo.IsName("Attack4"))
        {
            damageValue = 400;
        }
        else
        {
            damageValue = 100;
        }

        if (Skill1)
        {
            animator.SetBool("SkillSet1", true);
        }
        if (Skill2)
        {
            animator.SetBool("SkillSet2", true);
            Skill1 = false;
        }
        if (Skill3)
        {
            animator.SetBool("SkillSet3", true);
            animator.SetBool("SkillSet2", true);
            animator.SetBool("SkillSet1", true);
            Skill1 = false;
            Skill2 = false;
        }
        if (isExitingTrigger)
        {
            StartCoroutine(DelayUnAttack());
            isExitingTrigger = false;
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Enemy") && !isTiming)
        {
            isTiming = true;
            damageCoroutine = StartCoroutine(DealDamageOverTime(col));
        }
    }

    void OnTriggerStay(Collider col)
    {
        if (col.CompareTag("Enemy"))
        {
            animator.SetTrigger("IsEnemy");
            animator.SetBool("UnAttack", false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            isExitingTrigger = true;
            isTiming = false;
            if (damageCoroutine != null)
            {
                StopCoroutine(damageCoroutine);
                damageCoroutine = null;
            }
        }
    }

    private IEnumerator DealDamageOverTime(Collider col)
    {
        while (isTiming)
        {
            if (col != null)
            {
                Enemy_Spider enemy = col.transform.root.GetComponent<Enemy_Spider>();
                if (enemy != null)
                {
                    enemy.Damage(col);
                    enemy.EnemyHp -= damageValue;
                    Debug.Log("Enemy has taken damage: " + damageValue);
                }
                else
                {
                    isTiming = false;
                }
            }
            else
            {
                isTiming = false;
            }
            yield return new WaitForSeconds(1.0f);
        }
    }

    private IEnumerator DelayUnAttack()
    {
        yield return new WaitForSeconds(1.0f);
        animator.SetBool("UnAttack", true);
    }
}
