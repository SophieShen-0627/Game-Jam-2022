using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RobotController : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Robot initial parameter")]
    public float Velocity4RawMaterial;
    public float Velocity4ProductCreate;
    public float Velocity4RobotCreate;

    [Space(50)]
    public float Price4Sell;


    [Header("Animation Controller")]

    [SerializeField] Animator m_Animator;
   
    [SerializeField]
    Rigidbody m_Rigidbody;

    [SerializeField]
    private float jumpForce = 7f;
    bool isGrounded = false;
    Dictionary<string, int> actions = new Dictionary<string, int>();

    [HideInInspector]
    public int actionID = 0;

    [Header("Actions Names")]
    string NONE = "_none";
    string IDLE_1 = "idle_01";
    string WALK_1 = "walk_01";
    string RUN_1 = "run_01";
    string JUMP_1 = "jump_01";
    string JUMP_1_FALL = "jump_01_fall";
    string JUMP_1_LAND = "jump_01_land";
    string WORK_1 = "work_01";
    string HIT_1 = "hit_01";
    string LOSE_1 = "lose_01";
    string DIE_1 = "die_01";
    string REST_1 = "rest_01";

    [Header("Actions ID")]
    int NONE_ID = 0;
    int IDLE_1_ID = 1;
    int WALK_1_ID = 2;
    int RUN_1_ID = 3;
    int JUMP_1_ID = 4;
    int JUMP_1_FALL_ID = 5;
    int JUMP_1_LAND_ID = 6;
    int WORK_1_ID = 7;
    int HIT_1_ID = 8;
    int LOSE_1_ID = 9;
    int DIE_1_ID = 10;
    int WIN_DANCE_1_ID = 11;
    string backActionName = "idle_01";
    int backActionID = 1;
    private void Awake()
    {
        gameObject.transform.position = new Vector3(0, 5, 0);
        FindComponents();
        actions[NONE] = NONE_ID;
        actions[IDLE_1] = IDLE_1_ID;
        actions[WALK_1] = WALK_1_ID;
        actions[RUN_1] = RUN_1_ID;
        actions[JUMP_1] = JUMP_1_ID;
        actions[JUMP_1_FALL] = JUMP_1_FALL_ID;
        actions[JUMP_1_LAND] = JUMP_1_LAND_ID;
        actions[SPIN_1] = SPIN_1_ID;//NOT USED
        actions[WORK_1] = WORK_1_ID;
        actions[HIT_1] = HIT_1_ID;
        actions[LOSE_1] = LOSE_1_ID;
        actions[DIE_1] = DIE_1_ID;
        actions[REST_1] = WIN_DANCE_1_ID;
        backActionName = IDLE_1;
        backActionID = IDLE_1_ID;
        UpdateAnimationAction();
    }


    NavMeshAgent m_NavMeshAgent;

    
    void Start()
    {
        Velocity4ProductCreate = Random.Range(0, 10);
        Velocity4RawMaterial = Random.Range(0, 10);
        Velocity4RobotCreate = Random.Range(0, 10);

        Price4Sell = Random.Range(5, 15);

        m_NavMeshAgent = GetComponent<NavMeshAgent>();


        //ToIdle();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
