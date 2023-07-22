using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    [SerializeField] GameObject platForm;
    private WaitForSeconds wait = new WaitForSeconds(5);

    private void Start()
    {
        StartCoroutine(CreateObject());
    }

    IEnumerator CreateObject()
    {
        while (true)
        {
            yield return null;
            ObjectPoolManager.instance.GetQueue();
            yield return wait;
        }
    }

    void Update()
    {
        
    }

    /* void Start()
    {
        // gameObject�� �����ϴ� �Լ�
        // ù��° �Ű����� : �����ϰ���� ���� ������Ʈ
        // �ι�° �Ű����� : ���� ������Ʈ�� ��ġ
        // ����° �Ű����� : ���� ������Ʈ ȸ��

        Instantiate
            (
            platForm, 
            transform.position,
            Quaternion.identity
            );     
    }*/

}
