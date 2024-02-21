using UnityEngine;
using UnityEngine.Events;

public class DumbEnemy : MonoBehaviour
{
    public FloatReference MaxHp;
    public FloatReference MoveSpeed;

    public UnityEvent DamageEvent;

    private void Update()
    {
        Debug.Log(MaxHp.Value);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            DamageEvent?.Invoke();
        }
    }
}
