using UnityEngine;
using UnityEngine.Rendering;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] float _speed = 0.1f;
    [SerializeField] private Transform _playerTransform;
    private bool enable;
    private float _deltaTime;

    public void enableChase() { 
        enable = true;
    }
    public void disableChase() { enable = false; }

    private void Update()
    {
        if (enable == true) 
        {
            _deltaTime = Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, _playerTransform.position, _speed / _deltaTime)  ;

        }
    }


}
