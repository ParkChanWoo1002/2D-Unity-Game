using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolManager : MonoBehaviour
{
    public static ObjectPoolManager instance;

    [SerializeField] GameObject prefab;

    public Queue<GameObject> queue = new Queue<GameObject>();

    [SerializeField] int prefabCount = 5;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }



    private void Start()
    {
        for (int i =0; i< prefabCount; i++)
        {
            // 1.게임 오브젝트를 생성
            GameObject prefabObject = Instantiate(prefab, Vector3.zero, Quaternion.identity);
            // 2. 생성된 게임오브젝트를 순서대로 큐컨테이너에 저장합니다.
            queue.Enqueue(prefabObject);
            // 3. 게임 오브젝트를 비활성화합니다.
            prefabObject.SetActive(false);
          
        }
    }

    //queue에 데이터를 넣어주는 함수
    public void InsertQueue(GameObject insertObject)
    {
        insertObject.transform.position = Vector3.zero;
        queue.Enqueue(insertObject);
        insertObject.SetActive(false);
    }

    // queue에서 꺼내는 함수
    public void GetQueue()
    {
        GameObject tempObject = queue.Dequeue();
        tempObject.SetActive(true);
    }

}
