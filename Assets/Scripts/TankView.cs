using UnityEngine;

public class TankView : MonoBehaviour
{
    private TankController _tankController;

    private float _movement;
    private float _rotation;

    public Rigidbody rb;

    public void SetTankController(TankController tankController)
    {
        _tankController = tankController;
    }

    public Rigidbody GetRigidbody() => rb;

    private void Update()
    {
        Movement();
        if (_movement != 0)
            _tankController.Move(_movement, 30);
        if (_rotation != 0)
            _tankController.Rotate(_rotation, 150);
    }

    private void Movement()
    {
        _movement = Input.GetAxis("Vertical");
        _rotation = Input.GetAxis("Horizontal");
    }
}