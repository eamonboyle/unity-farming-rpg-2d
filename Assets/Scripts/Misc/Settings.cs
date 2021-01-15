using UnityEngine;

public static class Settings
{
    // Player movement.
    public const float runningSpeed = 5.333f;
    public const float walkingSpeed = 2.666f;

    // Player animation parameters.
    public static int xInput;
    public static int yInput;
    public static int isWalking; 
    public static int isRunning; 
    public static int isIdle; 
    public static int isCarrying;
    public static int toolEffect;
    public static int isUsingToolUp;
    public static int isUsingToolDown;
    public static int isUsingToolRight;
    public static int isUsingToolLeft;
    public static int isSwingingToolUp;
    public static int isSwingingToolDown;
    public static int isSwingingToolRight;
    public static int isSwingingToolLeft;
    public static int isLiftingToolUp;
    public static int isLiftingToolDown;
    public static int isLiftingToolRight; 
    public static int isLiftingToolLeft;
    public static int isPickingUp;
    public static int isPickingDown;
    public static int isPickingRight; 
    public static int isPickingLeft; 

    // Shared animation parameters.
    public static int idleUp; 
    public static int idleDown; 
    public static int idleLeft; 
    public static int idleRight;

    // Static constructor.
    static Settings()
    {
        // Player animation parameters.
        xInput = Animator.StringToHash("xInput");
        yInput = Animator.StringToHash("yInput");
        isWalking = Animator.StringToHash("isWalking");
        isRunning = Animator.StringToHash("isRunning");
        isIdle = Animator.StringToHash("isIdle");
        isCarrying = Animator.StringToHash("isCarrying");
        toolEffect = Animator.StringToHash("toolEffect");
        isUsingToolUp = Animator.StringToHash("isUsingToolUp");
        isUsingToolDown = Animator.StringToHash("isUsingToolDown");
        isUsingToolRight = Animator.StringToHash("isUsingToolRight");
        isUsingToolLeft = Animator.StringToHash("isUsingToolLeft");
        isSwingingToolUp = Animator.StringToHash("isSwingingToolUp");
        isSwingingToolDown = Animator.StringToHash("isSwingingToolDown");
        isSwingingToolRight = Animator.StringToHash("isSwingingToolRight");
        isSwingingToolLeft = Animator.StringToHash("isSwingingToolLeft");
        isLiftingToolUp = Animator.StringToHash("isLiftingToolUp");
        isLiftingToolDown = Animator.StringToHash("isLiftingToolDown");
        isLiftingToolRight = Animator.StringToHash("isLiftingToolRight");
        isLiftingToolLeft = Animator.StringToHash("isLiftingToolLeft");
        isPickingUp = Animator.StringToHash("isPickingUp");
        isPickingDown = Animator.StringToHash("isPickingDown");
        isPickingRight = Animator.StringToHash("isPickingRight");
        isPickingLeft = Animator.StringToHash("isPickingLeft");

        // Shared animation parameters.
        idleUp = Animator.StringToHash("idleUp");
        idleDown = Animator.StringToHash("idleDown");
        idleLeft = Animator.StringToHash("idleLeft");
        idleRight = Animator.StringToHash("idleRight");
    }
}
