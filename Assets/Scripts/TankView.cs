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

    private void Start()
    {
        GameObject camera = GameObject.Find("Main Camera");
        camera.transform.SetParent(transform);
        camera.transform.position = new Vector3(0f, 3f, -4f);
    }

    private void Update()
    {
        Movement();
        if (_movement != 0)
            _tankController.Move(_movement, _tankController.GetTankModel().movementSpeed);
        if (_rotation != 0)
            _tankController.Rotate(_rotation, _tankController.GetTankModel().rotationSpeed);
    }

    private void Movement()
    {
        _movement = Input.GetAxis("Vertical");
        _rotation = Input.GetAxis("Horizontal");
    }
}