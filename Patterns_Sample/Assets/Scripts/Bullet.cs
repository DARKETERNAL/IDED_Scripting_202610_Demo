using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour
{
    private new Rigidbody rigidbody;

    public Rigidbody Rigidbody => rigidbody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        Invoke("ReturnToPool", 5F);
    }

    public void ResetBullet(bool active = false)
    {
        rigidbody.linearVelocity = Vector3.zero;
        gameObject.SetActive(active);
    }

    private void ReturnToPool()
    {
        Pool.Instance.ReturnBullet(this);
    }
}