using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    private Vector2 direction;
    [SerializeField] float speed = 1.0f;
    
    void Update()
    {
        direction = new Vector2(0.1f, 0);
        transform.position -= (Vector3)direction * speed * Time.deltaTime;
    }

    // OnTirggerEnter2D : Trigger 와 충돌했다면 실행되는 메소드
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //자기 자신을 파괴
        Destroy(gameObject); 
        
    }
}
