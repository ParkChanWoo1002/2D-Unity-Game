using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    [SerializeField] GameObject platForm;

    void Start()
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
    }

    
    void Update()
    {
        
    }
}
