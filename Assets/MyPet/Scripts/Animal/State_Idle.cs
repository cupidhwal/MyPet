using UnityEngine;
using UnityEngine.AI;
using WOAT;

namespace MyPet.AI
{
    [System.Serializable]
    public class State_Idle : State<AnimalController>
    {
        // 필드
        #region Variables
        private Animator animator;
        /*private CharacterController characterController;
        private NavMeshAgent navMeshAgent;*/
        #endregion

        // 오버라이드
        #region Override
        // 초기화 메서드 - 생성 후 1회 실행
        public override void OnInitialized()
        {
            // 참조
            animator = context.GetComponent<Animator>();
            /*characterController = context.GetComponent<CharacterController>();
            navMeshAgent = context.GetComponent<NavMeshAgent>();*/
        }

        // 상태 전환 시 State Enter에 1회 실행
        public override void OnEnter() { }

        // 상태 전환 시 State Exit에 1회 실행
        public override void OnExit() { }

        public override void Update(float deltaTime)
        {
            
        }
        #endregion
    }
}