using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BuildingExitButtonBehaviors : MonoBehaviour
{

    private const string CAMPUS = "Campusv2BetterMovementLogic";

    private const float BOYLANEASTX = -28.20007f;
    private const float BOYLANEASTY = -12.20001f;
    private const float BOYLANWESTX = -6.499993f;
    private const float BOYLANWESTY = -12.30001f;
    private const float BOYLANMAINX = -17.70003f;
    private const float BOYLANMAINY = -11.80001f;
    private const float BOYLANCMRDX = -30.86018f; // campus road
    private const float BOYLANCMRDY = -25.60006f; // campus road
    
    private const float WESTQUADX = 31.7f;
    private const float WESTQUADY = -1.9f;

    private const float LIBX = -38.8f; // Library
    private const float LIBY = -2.8f; // Library

    private const float INGWESTX = -6.499993f;
    private const float INGWESTY = 8.099999f;
    private const float INGEASTX = -28.20007f;
    private const float INGEASTY = 7.899998f;
    private const float INGMAINX = -17.50003f;
    private const float INGMAINY = 6.999995f;

    private const float INGEXTMAINX = -36.60002f;
    private const float INGEXTMAINY = 18.00004f;
    private const float INGEXTBEDX = -0.0999978f; // bedford
    private const float INGEXTBEDY = 19.90004f; // bedfford


    // Start is called before the first frame update
    void Start()
    {
    }

    public void ExitBoylanMain()
    {
        PersistentData.Instance.setXOffset(BOYLANMAINX);
        PersistentData.Instance.setYOffset(BOYLANMAINY);
        SceneManager.LoadScene(CAMPUS);
    }

    public void ExitBoylanEast()
    {
        PersistentData.Instance.setXOffset(BOYLANEASTX);
        PersistentData.Instance.setYOffset(BOYLANEASTY);
        SceneManager.LoadScene(CAMPUS);
    }

    public void ExitBoylanWest()
    {
        PersistentData.Instance.setXOffset(BOYLANWESTX);
        PersistentData.Instance.setYOffset(BOYLANWESTY);
        SceneManager.LoadScene(CAMPUS);
    }

    public void ExitBoylanCampusRd()
    {
        PersistentData.Instance.setXOffset(BOYLANCMRDX);
        PersistentData.Instance.setYOffset(BOYLANCMRDY);
        SceneManager.LoadScene(CAMPUS);
    }

    public void ExitWestQuad()
    {
        PersistentData.Instance.setXOffset(WESTQUADX);
        PersistentData.Instance.setYOffset(WESTQUADY);
        SceneManager.LoadScene(CAMPUS);
    }

    public void ExitLibrary()
    {
        PersistentData.Instance.setXOffset(LIBX);
        PersistentData.Instance.setYOffset(LIBY);
        SceneManager.LoadScene(CAMPUS);
    }

    public void ExitIngersollWest()
    {
        PersistentData.Instance.setXOffset(INGWESTX);
        PersistentData.Instance.setYOffset(INGWESTY);
        SceneManager.LoadScene(CAMPUS);
    }

    public void ExitIngersollMain()
    {
        PersistentData.Instance.setXOffset(INGMAINX);
        PersistentData.Instance.setYOffset(INGMAINY);
        SceneManager.LoadScene(CAMPUS);
    }

    public void ExitIngersollEast()
    {
        PersistentData.Instance.setXOffset(INGEASTX);
        PersistentData.Instance.setYOffset(INGEASTY);
        SceneManager.LoadScene(CAMPUS);
    }

    public void ExitIngersollNewIng()
    {
        SceneManager.LoadScene("IngersollExt");
    }

    public void ExitIngersollExtMain()
    {
        PersistentData.Instance.setXOffset(INGEXTMAINX);
        PersistentData.Instance.setYOffset(INGEXTMAINY);
        SceneManager.LoadScene(CAMPUS);
    }

    public void ExitIngersollExtBedford()
    {
        PersistentData.Instance.setXOffset(INGEXTBEDX);
        PersistentData.Instance.setYOffset(INGEXTBEDY);
        SceneManager.LoadScene(CAMPUS);
    }

    public void ExitIngersollExtOldIng()
    {
        SceneManager.LoadScene("IngersollHall");
    }
}
