using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorOverrider : MonoBehaviour
{
    private Animator animatorOverrider;

    private void Awake()
    {
        animatorOverrider = GetComponent<Animator>();
    }

    public void SetAnimations(AnimatorOverrideController overridercontroller)
    {
        animatorOverrider.runtimeAnimatorController = overridercontroller;
    }
}
