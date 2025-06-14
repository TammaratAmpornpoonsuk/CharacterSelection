using UnityEngine;

public class TankController
{
    private TankModel _tankModel;
    private TankView _tankView;

    private Rigidbody _rb;

    public TankController(TankModel tankModel, TankView tankView)
    {
        _tankModel = tankModel;
        _tankView = GameObject.Instantiate<TankView>(tankView);
        _rb = _tankView.GetRigidbody();

        _tankModel.SetTankController(this);
        _tankView.SetTankController(this);

        _tankView.ChangeColor(_tankModel.color);
    }

    public void Move(float movement, float movementSpeed)
    {
        _rb.velocity = _tankView.transform.forward * movement * movementSpeed;
    }

    public void Rotate(float rotate, float rotateSpeed)
    {
        Vector3 vector = new Vector3(0f, rotate * rotateSpeed, 0f);
        Quaternion deltaRotation = Quaternion.Euler(vector * Time.deltaTime);
        _rb.MoveRotation(_rb.rotation * deltaRotation);
    }

    public TankModel GetTankModel() => _tankModel;
}