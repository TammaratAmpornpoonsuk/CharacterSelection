using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [System.Serializable]
    public class Tank
    {
        public float movementSpeed;
        public float rotationSpeed;
        public TankTypes tankType;
        public Material color;
    }

    public List<Tank> tankList;
    public TankView tankView;

    void Start()
    {
    }

    public void CreateTank(TankTypes tankType)
    {
        TankModel tankModel = new TankModel(
            tankList[(int)tankType].movementSpeed,
            tankList[(int)tankType].rotationSpeed,
            tankList[(int)tankType].tankType,
            tankList[(int)tankType].color
        );
        TankController tankController = new TankController(tankModel, tankView);
    }
}
