using UnityEngine;

public class CatW5 : MonoBehaviour
{
    [SerializeField] private bool _flipWSControls;
    [SerializeField] private float _moveSpeed = 1.0f;
    [SerializeField] private float _turnSpeed = 1.0f;
    [SerializeField] private Animator _animator;

    private string _isWalkingName = "IsWalking";

    private void Update()
    {
        // STEP 1 -----------------------------------------------------------------
        // W/S drive the cat along its own forward axis (local Z).
        // Vector3.forward is (0, 0, 1); scaling it by the vertical input gives
        // a direction, and scaling again by _moveSpeed * deltaTime converts it
        // into this frame's displacement.
        Vector3 translation = Vector3.forward * Input.GetAxis("Vertical");

        // STEP 2 -----------------------------------------------------------------
        // Flipping the controls is just negating the direction: multiplying the
        // vector by -1 turns forward into backward.
        float flip = _flipWSControls ? -1.0f : 1.0f;

        // Scale by speed and by the frame's elapsed time so movement is
        // frame-rate independent.
        translation = translation * _moveSpeed * flip * Time.deltaTime;

        // Translate applies the displacement in local space, so "forward" always
        // means the direction the cat is currently facing.
        transform.Translate(translation);

        // Turn with A/D.
        float rotation = Input.GetAxis("Horizontal") * _turnSpeed * Time.deltaTime;
        transform.Rotate(0, rotation, 0);

        // Drive the walk animation whenever the cat is moving or turning.
        if (translation.magnitude != 0.0f || rotation != 0.0f)
        {
            _animator.SetBool(_isWalkingName, true);
        }
        else
        {
            _animator.SetBool(_isWalkingName, false);
        }
    }
}
