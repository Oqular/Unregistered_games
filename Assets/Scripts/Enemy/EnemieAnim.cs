using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class EnemieAnim : MonoBehaviour
{

    public RuntimeAnimatorController controller;
    Animator animator;


    void Awake()
    {
        animator = GetComponent<Animator>();
        animator.runtimeAnimatorController = controller;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Death();
        }
        else if (Input.GetKeyDown(KeyCode.Tab))
        {
            Run();
        }
    }

    public void Run()
    {
        animator.Play("Run", 0);
        animator.SetFloat("Speed", 1f);
    }

    public void Death()
    {
        animator.Play("Death", 0);
        animator.SetTrigger("Death");
        StartCoroutine("Dead");
    }
    IEnumerator Dead()
    {
        yield return new WaitForSeconds(3.5f);
        Destroy(this.gameObject);
    }

}