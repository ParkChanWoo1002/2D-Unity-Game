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
        // gameObject를 생성하는 함수
        // 첫번째 매개변수 : 생성하고싶은 게임 오브젝트
        // 두번째 매개변수 : 게임 오브젝트의 위치
        // 세번째 매개변수 : 게임 오브젝트 회전

        Instantiate
            (
            platForm, 
            transform.position,
            Quaternion.identity
            );     
    }*/

}
