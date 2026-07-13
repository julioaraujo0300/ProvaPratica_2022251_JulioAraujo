using UnityEngine;

public class MoonController : MonoBehaviour
{
    [SerializeField] Transform target;      
    [SerializeField] float distance = 5f;   
    [SerializeField] float height = 2f;     
    [SerializeField] float speed = 30f;     

    private float currentAngle = 0f;

    void Update()
    {
        if (target == null) return;

        currentAngle += speed * Time.deltaTime;

        float rad = currentAngle * Mathf.Deg2Rad;
        Vector3 offset = new Vector3(Mathf.Cos(rad), 0f, Mathf.Sin(rad)) * distance;

        transform.position = target.position + offset + Vector3.up * height;
        transform.LookAt(target);
    }
}
