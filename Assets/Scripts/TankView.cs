using UnityEngine;

public class TankView : MonoBehaviour
{
    private TankController _tankController;

    public void SetTankController(TankController tankController)
    {
        _tankController = tankController;
    }
}