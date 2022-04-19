using UnityEngine;

public class TopDownController : MonoBehaviour
{
    [SerializeField, Header("移動速度"), Range(0, 500)]
    private float speed = 1.5f;
    private string parameterRun = "TriggerRun";
    private string parameterDead = "Death";
    private Animator ani;
    private Rigidbody2D rig;

    private void Awake()
    {
        ani = GetComponent<Animator>();
        rig = GetComponent<Rigibody2D>();

    }
}
