using UnityEngine;
using UnityEngine.AI;
using WOAT;

namespace MyPet.AI
{
    /// <summary>
    /// ������ �����ϴ� Ŭ���� (�������� �θ� Ŭ����)
    /// </summary>
    public class AnimalController : MonoBehaviour
    {
        // �ʵ�
        #region Variables
        protected StateMachine<AnimalController> stateMachine;

        // ����
        protected Animator animator;
        //protected CharacterController characterController;
        //protected NavMeshAgent agent;
        #endregion

        // ������ ����Ŭ
        #region Life Cycle
        protected virtual void Start()
        {
            // StateMachine ����
            stateMachine = new(this, new State_Idle());

            // ����
            animator = GetComponent<Animator>();
            //characterController = GetComponent<CharacterController>();
            //agent = GetComponent<NavMeshAgent>();
        }

        protected virtual void Update()
        {
            // ���� ������ ������Ʈ�� stateMachine�� ������Ʈ�� ���� ����
            stateMachine.Update(Time.deltaTime);
        }
        #endregion

        // �޼���
        #region Methods
        public R ChangeState<R>() where R : State<AnimalController>
        {
            return stateMachine.ChangeState<R>();
        }
        #endregion
    }
}