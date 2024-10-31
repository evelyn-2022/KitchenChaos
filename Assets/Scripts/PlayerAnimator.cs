using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour {
    [SerializeField] private Player player;

    private Animator animator;

    private const string Is_Walking = "IsWalking";

    private void Awake() {
        animator = GetComponent<Animator>();

    }
    private void Update() {
        animator.SetBool(Is_Walking, player.IsWalking());
    }
}
