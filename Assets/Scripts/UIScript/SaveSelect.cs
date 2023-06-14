using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using UnityEngine.EventSystems;

public class SaveSelect : MonoBehaviour
{
    public Text[] slotText;		// ���Թ�ư �Ʒ��� �����ϴ� Text��
    bool[] savefile = new bool[8];	// ���̺����� �������� ����

    public Option option;

    GameObject clickObject;

    public Text text;
    
    // Start is called before the first frame update
    void Start()
    {
        option = GameObject.Find("OptionCanvas").GetComponent<Option>();
        text = GameObject.Find("SaveCanvas").transform.Find("ConfirmPanel").transform.Find("Text").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SaveAndLoad()
    {
        // ���Ժ��� ����� �����Ͱ� �����ϴ��� �Ǵ�.
        for (int i = 0; i < 8; i++)
        {
            if (File.Exists(GameManager.instance.path + $"{i}"))	// �����Ͱ� �ִ� ���
            {
                savefile[i] = true;			// �ش� ���� ��ȣ�� bool�迭 true�� ��ȯ
                GameManager.instance.nowSlot = i;	// ������ ���� ��ȣ ����
                GameManager.instance.LoadData();	// �ش� ���� ������ �ҷ���
                slotText[i].text = GameManager.instance.nowPlayer.TimeNow;	// ��ư�� �ð�ǥ��
            }
            else	// �����Ͱ� ���� ���
            {
                slotText[i].text = "�������";
            }
        }
        // �ҷ��� �����͸� �ʱ�ȭ��Ŵ.(��ư�� �г����� ǥ���ϱ������̾��� ����)
        GameManager.instance.DataClear();
    }

    public void Slot(int number)	// ������ ��� ����
    {
        
        StartCoroutine(StartSlot(number));
    }

    public IEnumerator StartSlot(int number)
    {
        GameManager.instance.nowSlot = number;	// ������ ��ȣ�� ���Թ�ȣ�� �Է���.

        if (option.SaveLoad) //���̺� ����(ture�ϰ��)
        {
            text.text = "����ðڽ��ϱ�?";
            if (savefile[number])   // bool �迭���� ���� ���Թ�ȣ�� true��� = ������ �����Ѵٴ� ��
            {
                
                GameObject.Find("SaveCanvas").transform.Find("ConfirmPanel").gameObject.SetActive(true);
                yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject).name == "Yes" || (clickObject = EventSystem.current.currentSelectedGameObject).name == "No");
                switch (clickObject.name)
                {
                    case "Yes":
                        GameObject.Find("SaveCanvas").transform.Find("ConfirmPanel").gameObject.SetActive(false);
                        GameManager.instance.SaveData();
                        break;
                    case "No":
                        GameObject.Find("SaveCanvas").transform.Find("ConfirmPanel").gameObject.SetActive(false);
                        break;
                }
                
            }
            else    // bool �迭���� ���� ���Թ�ȣ�� false��� �����Ͱ� ���ٴ� ��
            {
                GameManager.instance.SaveData();
            }
        }
        else
        {
            text.text = "�ҷ����ðڽ��ϱ�?";
            if (savefile[number])   // bool �迭���� ���� ���Թ�ȣ�� true��� = ������ �����Ѵٴ� ��
            {
                
                GameObject.Find("SaveCanvas").transform.Find("ConfirmPanel").gameObject.SetActive(true);
                yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject).name == "Yes" || (clickObject = EventSystem.current.currentSelectedGameObject).name == "No");
                switch (clickObject.name)
                {
                    case "Yes":
                        GameObject.Find("SaveCanvas").transform.Find("ConfirmPanel").gameObject.SetActive(false);
                        GameManager.instance.LoadGame();    // �����͸� �ε��ϰ�
                        break;
                    case "No":
                        GameObject.Find("SaveCanvas").transform.Find("ConfirmPanel").gameObject.SetActive(false);
                        break;
                }

            }
            else    // bool �迭���� ���� ���Թ�ȣ�� false��� �����Ͱ� ���ٴ� ��
            {
                
            }
        }
        SaveAndLoad();
    }

}
