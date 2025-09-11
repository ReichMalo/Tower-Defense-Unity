using UnityEngine;

public class Shop : MonoBehaviour
{
    private BuildManager buildManager;

    private void Start()
    {
        buildManager = BuildManager.instance;
    }
    public void PurchasseStandartTurret()
    {
        Debug.Log("Standart Turret Select");
        buildManager.SetTurretToBuild(buildManager.standardTurretPrefab);
    }

    public void PurchasseMisileLuncher()
    {
        Debug.Log("lance-missile Select");
        buildManager.SetTurretToBuild(buildManager.missileLaucherPrefab);
    }
}
