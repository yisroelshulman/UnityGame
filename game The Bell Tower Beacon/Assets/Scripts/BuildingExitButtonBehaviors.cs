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

    private const float JAMESMAINX = 19.20004f;
    private const float JAMESMAINY = -14.10001f;

    private const float ROOSEASTX = 10.4f;
    private const float ROOSEASTY = 10.60001f;
    private const float ROOSMAINX = 19.70004f;
    private const float ROOSMAINY = 9.2f;
    private const float ROOSWESTX = 28.80007f;
    private const float ROOSWESTY = 11.20001f;
    private const float ROOSBEDX = 5.499998f; // bedford
    private const float ROOSBEDY = 16.50003f; // bedford

    private const float WESTEX = 62.09961f;
    private const float WESTEY = 12.80002f;

    private const float WHITEHEADMAINX = -48.19984f;
    private const float WHITEHEADMAINY = -19.30003f;
    private const float WHITEHEADCMRDX = -45.19988f;
    private const float WHITEHEADCMRDY = -25.60006f;

    private const float SUBOWESTX = -41.69994f;
    private const float SUBOWESTY = -31.00008f;
    private const float SUBOEASTX = -51.09979f;
    private const float SUBOEASTY = -31.50008f;


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

    public void ExitJamesMain()
    {
        PersistentData.Instance.setXOffset(JAMESMAINX);
        PersistentData.Instance.setYOffset(JAMESMAINY);
        SceneManager.LoadScene(CAMPUS);
    }

    public void ExitRooseveltMain()
    {
        PersistentData.Instance.setXOffset(ROOSMAINX);
        PersistentData.Instance.setYOffset(ROOSMAINY);
        SceneManager.LoadScene(CAMPUS);
    }

    public void ExitRooseveltEast()
    {
        PersistentData.Instance.setXOffset(ROOSEASTX);
        PersistentData.Instance.setYOffset(ROOSEASTY);
        SceneManager.LoadScene(CAMPUS);
    }

    public void ExitRooseveltWest()
    {
        PersistentData.Instance.setXOffset(ROOSWESTX);
        PersistentData.Instance.setYOffset(ROOSWESTY);
        SceneManager.LoadScene(CAMPUS);
    }

    public void ExitRooseveltBedfor()
    {
        PersistentData.Instance.setXOffset(ROOSBEDX);
        PersistentData.Instance.setYOffset(ROOSBEDY);
        SceneManager.LoadScene(CAMPUS);
    }

    public void ExitWestEndMain()
    {
        PersistentData.Instance.setXOffset(WESTEX);
        PersistentData.Instance.setYOffset(WESTEY);
        SceneManager.LoadScene(CAMPUS);
    }

    public void ExitWhiteheadMain()
    {
        PersistentData.Instance.setXOffset(WHITEHEADMAINX);
        PersistentData.Instance.setYOffset(WHITEHEADMAINY);
        SceneManager.LoadScene(CAMPUS);
    }

    public void ExitWhiteheadCampusrd()
    {
        PersistentData.Instance.setXOffset(WHITEHEADCMRDX);
        PersistentData.Instance.setYOffset(WHITEHEADCMRDY);
        SceneManager.LoadScene(CAMPUS);
    }

    public void ExitSUBOEast()
    {
        PersistentData.Instance.setXOffset(SUBOEASTX);
        PersistentData.Instance.setYOffset(SUBOEASTY);
        SceneManager.LoadScene(CAMPUS);
    }

    public void ExitSUBOWest()
    {
        PersistentData.Instance.setXOffset(SUBOWESTX);
        PersistentData.Instance.setYOffset(SUBOWESTY);
        SceneManager.LoadScene(CAMPUS);
    }
}
