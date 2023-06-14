using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingManager : MonoBehaviour
{
    //�� ��ũ��Ʈ�� �÷��̾ ���������� �Ѿ���� �� � ������ �����־�� �ϴ����� �����ϴ� ��ũ��Ʈ
    public GameManager gameManager;
    public Camera cam;
    public SoundManager2 soundManager2; //BGM ���

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        soundManager2 = GameObject.FindWithTag("BGM").GetComponent<SoundManager2>();

        soundManager2.StopBgm();

        switch (gameManager.EndingCond)  //���ӸŴ����� �������ǿ� ���� �ٸ� ������ ���
        {
            case "Die":
                cam.transform.position = new Vector3(0, 40, -10);//ī�޶� �̵�
                GameObject.Find("EndingBackground").transform.Find("Ending_Die").gameObject.SetActive(true);
                GameObject.Find("Canvas").transform.Find("ReturnTitle").gameObject.SetActive(true);
                break;

            case "Ending_A_K":
                cam.transform.position = new Vector3(0,0,-10);//ī�޶� �̵�
                GameObject.Find("EndingBackground").transform.Find("Ending_A_K").gameObject.SetActive(true);
                break;

            case "Ending_A_P":
                cam.transform.position = new Vector3(0, 20, -10);//ī�޶� �̵�
                GameObject.Find("EndingBackground").transform.Find("Ending_A_P").gameObject.SetActive(true);
                break;

            case "Ending_Supia":
                cam.transform.position = new Vector3(0, -20, -10);//ī�޶� �̵�
                GameObject.Find("EndingBackground").transform.Find("Ending_Supia").gameObject.SetActive(true);
                break;

            case "Ending_Nuclear":
                cam.transform.position = new Vector3(0, -40, -10);//ī�޶� �̵�
                GameObject.Find("EndingBackground").transform.Find("Ending_Nuclear").gameObject.SetActive(true);
                break;

            case "Ending_Raid":
                cam.transform.position = new Vector3(0, -60, -10);//ī�޶� �̵�
                GameObject.Find("EndingBackground").transform.Find("Ending_Raid").gameObject.SetActive(true);
                break;

            case "Ending_Pinkdoor":
                cam.transform.position = new Vector3(0, -80, -10);//ī�޶� �̵�
                GameObject.Find("EndingBackground").transform.Find("Ending_Pinkdoor").gameObject.SetActive(true);
                break;

            default:
                Debug.Log("���� �����Դϴ�.");
                break;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log(this.name);
            GameObject.Find("OptionCanvas").transform.Find("SoundPanel").gameObject.SetActive(true);
        }
    }

    public void ReturnTitle()
    {
        GameObject.Find("Canvas").transform.Find("ReturnTitle").gameObject.SetActive(false);
        Destroy(GameObject.Find("GameManager").gameObject);
        SceneManager.LoadScene("TitleScene");
    }
}
