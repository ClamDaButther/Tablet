using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TabletMenu : MonoBehaviour
{

    public bool OPTIONON = true;

    public Material m_EMcreditsscreen;
    public Material m_EMexitscreen;
    public Material m_EMlevelscreen;
    public Material m_EMoptionsscreenOFF;
    public Material m_EMoptionsscreenON;
    public Material m_EMstartscreen;

    public GameObject Hand;
    public GameObject Tablet;
    public GameObject FloatingPointBehindHead;

    //tag on button
    private GameObject ButtonExitGame;
    private GameObject ButtonBack;
    private GameObject ButtonCreditScreenOPTIONSCEENOFF;
    private GameObject ButtonCreditScreenOPTIONON;
    private GameObject ButtonLevelScreen;
    private GameObject StartLevel;
    private GameObject ExitScreen;
    private GameObject CreditScreen;
    private GameObject OptionScreenButton;

    public GameObject NullInvloed;

    private GameObject s1;
    private GameObject s2;
    private GameObject s3;
    private GameObject s4;
    private GameObject s5;
    private GameObject s6;


    //ButtonPads
    public GameObject ButtonScreenCredit;
    public GameObject ButtonScreenExit;
    public GameObject ButtonScreenLevels;
    public GameObject ButtonScreenOFFOption;
    public GameObject ButtonScreenONOption;
    public GameObject ButtonScreenStartScreen;


    public float HTM = 0.2f;
    void Update()
    {

        s1 = NullInvloed;
        s2 = NullInvloed;
        s3 = NullInvloed;
        s4 = NullInvloed;
        s5 = NullInvloed;
        s6 = NullInvloed;

        ButtonExitGame = NullInvloed;
        ButtonBack = NullInvloed;
        ButtonCreditScreenOPTIONSCEENOFF = NullInvloed;
        ButtonCreditScreenOPTIONON = NullInvloed;
        ButtonLevelScreen = NullInvloed;
        StartLevel = NullInvloed;
        ExitScreen = NullInvloed;
        CreditScreen = NullInvloed;
        OptionScreenButton = NullInvloed;

        if(GameObject.FindGameObjectWithTag("s1") != null)
        {
            s1 = GameObject.FindGameObjectWithTag("s1");
        }
        if (GameObject.FindGameObjectWithTag("s2") != null)
        {
            s1 = GameObject.FindGameObjectWithTag("s2");
        }
        if (GameObject.FindGameObjectWithTag("s3") != null)
        {
            s1 = GameObject.FindGameObjectWithTag("s3");
        }
        if (GameObject.FindGameObjectWithTag("s4") != null)
        {
            s1 = GameObject.FindGameObjectWithTag("s4");
        }
        if (GameObject.FindGameObjectWithTag("s5") != null)
        {
            s1 = GameObject.FindGameObjectWithTag("s5");
        }
        if (GameObject.FindGameObjectWithTag("s6") != null)
        {
            s1 = GameObject.FindGameObjectWithTag("s6");
        }

        if (GameObject.FindGameObjectWithTag("ButtonExitGame") != null)
        {
            ButtonExitGame = GameObject.FindGameObjectWithTag("ButtonExitGame");
        }
        if (GameObject.FindGameObjectWithTag("BACKBUTTON") != null)
        {
            ButtonBack = GameObject.FindGameObjectWithTag("BACKBUTTON");
        }
        if (GameObject.FindGameObjectWithTag("ButtonCreditScreenOPTIONSCEENOFF") != null)
        {
            ButtonCreditScreenOPTIONSCEENOFF = GameObject.FindGameObjectWithTag("ButtonCreditScreenOPTIONSCEENOFF");
        }
        if (GameObject.FindGameObjectWithTag("ButtonCreditScreenOPTIONON") != null)
        {
            ButtonCreditScreenOPTIONON = GameObject.FindGameObjectWithTag("ButtonCreditScreenOPTIONON");
        }
        if (GameObject.FindGameObjectWithTag("ButtonLevelScreen") != null)
        {
            ButtonLevelScreen = GameObject.FindGameObjectWithTag("ButtonLevelScreen");
        }
        if (GameObject.FindGameObjectWithTag("StartLevel") != null)
        {
            StartLevel = GameObject.FindGameObjectWithTag("StartLevel");
        }
        if (GameObject.FindGameObjectWithTag("ExitScreen") != null)
        {
            ExitScreen = GameObject.FindGameObjectWithTag("ExitScreen");
        }
        if (GameObject.FindGameObjectWithTag("CreditScreen") != null)
        {
            CreditScreen = GameObject.FindGameObjectWithTag("CreditScreen");
        }
        if (GameObject.FindGameObjectWithTag("OptionScreenButton") != null)
        {
            OptionScreenButton = GameObject.FindGameObjectWithTag("OptionScreenButton");
        }






        //rotations and positions
        s1.transform.position = Tablet.transform.position;
        s1.transform.rotation = Tablet.transform.rotation;

        s2.transform.position = Tablet.transform.position;
        s2.transform.rotation = Tablet.transform.rotation;

        s3.transform.position = Tablet.transform.position;
        s3.transform.rotation = Tablet.transform.rotation;

        s4.transform.position = Tablet.transform.position;
        s4.transform.rotation = Tablet.transform.rotation;

        s5.transform.position = Tablet.transform.position;
        s5.transform.rotation = Tablet.transform.rotation;

        s6.transform.position = Tablet.transform.position;
        s6.transform.rotation = Tablet.transform.rotation;

        Tablet.transform.position = FloatingPointBehindHead.transform.position;

        //de rest
        if (Vector3.Distance(Hand.transform.position, CreditScreen.transform.position) < HTM)
        {
            Tablet.GetComponent<Renderer>().material = m_EMcreditsscreen;
            ButtonScreenStartScreen.SetActive(false);
            ButtonScreenCredit.SetActive(false);
            ButtonScreenExit.SetActive(false);
            ButtonScreenLevels.SetActive(false);
            ButtonScreenOFFOption.SetActive(false);
            ButtonScreenONOption.SetActive(false);
            ButtonScreenCredit.SetActive(true);
        }
        if (Vector3.Distance(Hand.transform.position, ButtonLevelScreen.transform.position) < HTM)
        {
            Tablet.GetComponent<Renderer>().material = m_EMlevelscreen;
            ButtonScreenStartScreen.SetActive(false);
            ButtonScreenCredit.SetActive(false);
            ButtonScreenExit.SetActive(false);
            ButtonScreenLevels.SetActive(false);
            ButtonScreenOFFOption.SetActive(false);
            ButtonScreenONOption.SetActive(false);
            ButtonScreenLevels.SetActive(true);
        }
        if (Vector3.Distance(Hand.transform.position, OptionScreenButton.transform.position) < HTM)
        {
            Tablet.GetComponent<Renderer>().material = m_EMoptionsscreenON; 
            ButtonScreenStartScreen.SetActive(false);
            ButtonScreenCredit.SetActive(false);
            ButtonScreenExit.SetActive(false);
            ButtonScreenLevels.SetActive(false);
            ButtonScreenOFFOption.SetActive(false);
            ButtonScreenONOption.SetActive(false);
            ButtonScreenONOption.SetActive(true);
        }

        ////m_EMoptionsscreenOFF?

        if (Tablet.GetComponent<Renderer>().material == m_EMoptionsscreenON)
        {
            if (OPTIONON == true)
            {
                Tablet.GetComponent<Renderer>().material = m_EMoptionsscreenON;
                AudioListener.volume = 0.5f;
            }
        }
        if (Tablet.GetComponent<Renderer>().material == m_EMoptionsscreenOFF)
        {
            if (OPTIONON == false)
            {
                Tablet.GetComponent<Renderer>().material = m_EMoptionsscreenOFF;
                AudioListener.volume = 0f;
            }
        }

        if (Vector3.Distance(Hand.transform.position, ButtonCreditScreenOPTIONON.transform.position) < HTM)
        {
            OPTIONON = true;
        }
        if (Vector3.Distance(Hand.transform.position, ButtonCreditScreenOPTIONSCEENOFF.transform.position) < HTM)
        {
            OPTIONON = false;
        }

        if (Vector3.Distance(Hand.transform.position, ButtonBack.transform.position) < HTM)
        {
            Tablet.GetComponent<Renderer>().material = m_EMstartscreen;
            ButtonScreenStartScreen.SetActive(false);
            ButtonScreenCredit.SetActive(false);
            ButtonScreenExit.SetActive(false);
            ButtonScreenLevels.SetActive(false);
            ButtonScreenOFFOption.SetActive(false);
            ButtonScreenONOption.SetActive(false);
            ButtonScreenStartScreen.SetActive(true);
        }

        if (Vector3.Distance(Hand.transform.position, ExitScreen.transform.position) < HTM)
        {
            Tablet.GetComponent<Renderer>().material = m_EMexitscreen;
            ButtonScreenStartScreen.SetActive(false);
            ButtonScreenCredit.SetActive(false);
            ButtonScreenExit.SetActive(false);
            ButtonScreenLevels.SetActive(false);
            ButtonScreenOFFOption.SetActive(false);
            ButtonScreenONOption.SetActive(false);
            ButtonScreenExit.SetActive(true);
        }

        if (Vector3.Distance(Hand.transform.position, ButtonExitGame.transform.position) < HTM)
        {
         //   Application.Quit();
        }

        if(Vector3.Distance(Hand.transform.position, StartLevel.transform.position) < HTM)
        {
            //SceneManager.LoadScene (sceneBuildIndex: Put-the-number-here );
            //SceneManager.LoadScene (sceneName:"Put-the-name-of-the-scene-here");
        }

    }

    


}
