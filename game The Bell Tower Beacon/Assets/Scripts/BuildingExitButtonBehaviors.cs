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
        PersistentData.Instance.SetXOffset(BOYLANMAINX);
        PersistentData.Instance.SetYOffset(BOYLANMAINY);
        SceneManager.LoadScene(CAMPUS);
    }

    public void ExitBoylanEast()
    {
        PersistentData.Instance.SetXOffset(BOYLANEASTX);
        PersistentData.Instance.SetYOffset(BOYLANEASTY);
        SceneManager.LoadScene(CAMPUS);
    }

    public void ExitBoylanWest()
    {
        PersistentData.Instance.SetXOffset(BOYLANWESTX);
        PersistentData.Instance.SetYOffset(BOYLANWESTY);
        SceneManager.LoadScene(CAMPUS);
    }

    public void ExitBoylanCampusRd()
    {
        PersistentData.Instance.SetXOffset(BOYLANCMRDX);
        PersistentData.Instance.SetYOffset(BOYLANCMRDY);
        SceneManager.LoadScene(CAMPUS);
    }

    public void ExitWestQuad()
    {
        PersistentData.Instance.SetXOffset(WESTQUADX);
        PersistentData.Instance.SetYOffset(WESTQUADY);
        SceneManager.LoadScene(CAMPUS);
    }

    public void ExitLibrary()
    {
        PersistentData.Instance.SetXOffset(LIBX);
        PersistentData.Instance.SetYOffset(LIBY);
        SceneManager.LoadScene(CAMPUS);
    }

    public void ExitIngersollWest()
    {
        PersistentData.Instance.SetXOffset(INGWESTX);
        PersistentData.Instance.SetYOffset(INGWESTY);
        SceneManager.LoadScene(CAMPUS);
    }

    public void ExitIngersollMain()
    {
        PersistentData.Instance.SetXOffset(INGMAINX);
        PersistentData.Instance.SetYOffset(INGMAINY);
        SceneManager.LoadScene(CAMPUS);
    }

    public void ExitIngersollEast()
    {
        PersistentData.Instance.SetXOffset(INGEASTX);
        PersistentData.Instance.SetYOffset(INGEASTY);
        SceneManager.LoadScene(CAMPUS);
    }

    public void ExitIngersollNewIng()
    {
        SceneManager.LoadScene("IngersollExt");
    }

    public void ExitIngersollExtMain()
    {
        PersistentData.Instance.SetXOffset(INGEXTMAINX);
        PersistentData.Instance.SetYOffset(INGEXTMAINY);
        SceneManager.LoadScene(CAMPUS);
    }

    public void ExitIngersollExtBedford()
    {
        PersistentData.Instance.SetXOffset(INGEXTBEDX);
        PersistentData.Instance.SetYOffset(INGEXTBEDY);
        SceneManager.LoadScene(CAMPUS);
    }

    public void ExitIngersollExtOldIng()
    {
        SceneManager.LoadScene("IngersollHall");
    }

    public void ExitJamesMain()
    {
        PersistentData.Instance.SetXOffset(JAMESMAINX);
        PersistentData.Instance.SetYOffset(JAMESMAINY);
        SceneManager.LoadScene(CAMPUS);
    }

    public void ExitRooseveltMain()
    {
        PersistentData.Instance.SetXOffset(ROOSMAINX);
        PersistentData.Instance.SetYOffset(ROOSMAINY);
        SceneManager.LoadScene(CAMPUS);
    }

    public void ExitRooseveltEast()
    {
        PersistentData.Instance.SetXOffset(ROOSEASTX);
        PersistentData.Instance.SetYOffset(ROOSEASTY);
        SceneManager.LoadScene(CAMPUS);
    }

    public void ExitRooseveltWest()
    {
        PersistentData.Instance.SetXOffset(ROOSWESTX);
        PersistentData.Instance.SetYOffset(ROOSWESTY);
        SceneManager.LoadScene(CAMPUS);
    }

    public void ExitRooseveltBedfor()
    {
        PersistentData.Instance.SetXOffset(ROOSBEDX);
        PersistentData.Instance.SetYOffset(ROOSBEDY);
        SceneManager.LoadScene(CAMPUS);
    }

    public void ExitWestEndMain()
    {
        PersistentData.Instance.SetXOffset(WESTEX);
        PersistentData.Instance.SetYOffset(WESTEY);
        SceneManager.LoadScene(CAMPUS);
    }

    public void ExitWhiteheadMain()
    {
        PersistentData.Instance.SetXOffset(WHITEHEADMAINX);
        PersistentData.Instance.SetYOffset(WHITEHEADMAINY);
        SceneManager.LoadScene(CAMPUS);
    }

    public void ExitWhiteheadCampusrd()
    {
        PersistentData.Instance.SetXOffset(WHITEHEADCMRDX);
        PersistentData.Instance.SetYOffset(WHITEHEADCMRDY);
        SceneManager.LoadScene(CAMPUS);
    }

    public void ExitSUBOEast()
    {
        PersistentData.Instance.SetXOffset(SUBOEASTX);
        PersistentData.Instance.SetYOffset(SUBOEASTY);
        SceneManager.LoadScene(CAMPUS);
    }

    public void ExitSUBOWest()
    {
        PersistentData.Instance.SetXOffset(SUBOWESTX);
        PersistentData.Instance.SetYOffset(SUBOWESTY);
        SceneManager.LoadScene(CAMPUS);
    }
}
