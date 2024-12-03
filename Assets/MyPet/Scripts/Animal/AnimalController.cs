using UnityEngine;
using UnityEngine.AI;
using WOAT;

namespace MyPet.AI
{
    /// <summary>
    /// 동물을 제어하는 클래스 (동물들의 부모 클래스)
    /// </summary>
    public class AnimalController : MonoBehaviour
    {
        // 필드
        #region Variables
        protected StateMachine<AnimalController> stateMachine;

        // 참조
        protected Animator animator;
        //protected CharacterController characterController;
        //protected NavMeshAgent agent;
        #endregion

        // 라이프 사이클
        #region Life Cycle
        protected virtual void Start()
        {
            // StateMachine 생성
            stateMachine = new(this, new State_Idle());

            // 참조
            animator = GetComponent<Animator>();
            //characterController = GetComponent<CharacterController>();
            //agent = GetComponent<NavMeshAgent>();
        }

        protected virtual void Update()
        {
            // 현재 상태의 업데이트를 stateMachine의 업데이트를 통해 실행
            stateMachine.Update(Time.deltaTime);
        }
        #endregion

        // 메서드
        #region Methods
        public R ChangeState<R>() where R : State<AnimalController>
        {
            return stateMachine.ChangeState<R>();
        }
        #endregion
    }
}