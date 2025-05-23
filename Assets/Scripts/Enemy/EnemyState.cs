using System.Collections;
using System.Collections.Generic;
using UnityEditor.AnimatedValues;
using UnityEngine;

public class EnemyState 
{
    protected EnemyStateMachine stateMachine;
    protected Enemy enemyBase;
    protected Rigidbody2D rb;

    protected bool triggerCalled;
    private string animBoolName;

    protected float stateTimer;

    public EnemyState(Enemy _enemyBase, EnemyStateMachine _stateMachine, string _animBollName)
    {
        this.enemyBase = _enemyBase;
        this.stateMachine = _stateMachine;
        this.animBoolName = _animBollName;
    }

    public virtual void Enter()
    {

        triggerCalled = false;
        rb = enemyBase.rb; 
        enemyBase.anim.SetBool(animBoolName, true);
    }

    public virtual void Update()
    {
        stateTimer -= Time.deltaTime;
    }
    public virtual void Exit()
    {
        enemyBase.anim.SetBool(animBoolName, false);
    }

    public virtual void AnimationFinishTrigger()
    {
        triggerCalled = true;
    }
}
