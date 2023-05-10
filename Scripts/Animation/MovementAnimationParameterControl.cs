
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Windows;

public class MovementAnimationParameterControl : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        EventHandler.MovementEvent += SetAnimationParameters;
    }

    private void OnDisable()
    {
        EventHandler.MovementEvent -= SetAnimationParameters;
    }

    private void SetAnimationParameters(float xInput, float yInput,
    bool isWalking, bool isRunning, bool isIdle, bool isCarrying,
    ToolEffect toolEffect,
    bool isUsingToolRight, bool isUsingToolLeft, bool isUsingToolUp, bool isUsingtoolDown,
    bool isLiftingToolRight, bool isLiftingToolLeft, bool isLiftingToolUp, bool isLiftingToolDown,
    bool isPickingRight, bool isPickingLeft, bool isPickingUp, bool isPickingDown,
    bool isSwingingToolRight, bool isSwingingToolLeft, bool isSwingingToolUp, bool isSwingingToolDown,
    bool idleUp, bool idleDown, bool idleLeft, bool idleRight)
    {
        animator.SetFloat(Settings.xInput, xInput);
        animator.SetFloat(Settings.yInput, yInput);
        animator.SetBool(Settings.isWalking, isWalking);
        animator.SetBool(Settings.isRunning, isRunning);

        animator.SetInteger(Settings.toolEffect, (int)toolEffect);

        if(isUsingToolRight)
        {
            animator.SetTrigger(Settings.isUsingToolRight);
        }
        if(isUsingToolLeft) {
            animator.SetTrigger(Settings.isUsingToolLeft);
        }
        if(isUsingToolUp) { 
            animator.SetTrigger(Settings.isUsingToolUp); 
        }
        if(isUsingtoolDown)
        {
            animator.SetTrigger(Settings.isUsingToolDown);
        }
        if (isLiftingToolRight)
        {
            animator.SetTrigger(Settings.isLiftingToolRight);
        }
        if (isLiftingToolLeft)
        {
            animator.SetTrigger(Settings.isLiftingToolLeft);
        }
        if (isLiftingToolUp)
        {
            animator.SetTrigger(Settings.isLiftingToolUp);
        }
        if (isLiftingToolDown)
        {
            animator.SetTrigger(Settings.isLiftingToolDown);
        }
        if (isSwingingToolRight)
        {
            animator.SetTrigger(Settings.isSwingingToolRight);
        }
        if(isSwingingToolLeft) {
            animator.SetTrigger(Settings.isSwingingToolLeft);
        }
        if(isSwingingToolUp)
        {
            animator.SetTrigger(Settings.isSwingingToolUp);
        }
        if (isSwingingToolDown)
        {
            animator.SetTrigger(Settings.isSwingingToolDown);
        }
        if (isPickingRight)
        {
            animator.SetTrigger(Settings.isPickingRight);
        }
        if (isPickingLeft)
        {
            animator.SetTrigger(Settings.isPickingLeft);
        }
        if (isPickingUp)
        {
            animator.SetTrigger(Settings.isPickingUp);
        }
        if (isPickingDown)
        {
            animator.SetTrigger(Settings.isPickingDown);
        }

        if (idleRight)
        {
            animator.SetTrigger(Settings.idleRight);
        }
        if (idleLeft)
        {
            animator.SetTrigger(Settings.idleLeft);
        }
        if (idleUp)
        {
            animator.SetTrigger(Settings.idleUp);
        }
        if (idleDown)
        {
            animator.SetTrigger(Settings.idleDown);
        }
        }
        
    private void AnimationEventPlayFootstepSound()
    {
        AudioManager.Instance.PlaySound(SoundName.effectFootstepHardGround);
    }
}
