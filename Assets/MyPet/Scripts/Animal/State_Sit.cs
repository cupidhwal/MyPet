using UnityEngine;
using UnityEngine.AI;
using WOAT;

namespace MyPet.AI
{
    [System.Serializable]
    public class State_Sit : State<AnimalController>
    {
        // 필드
        #region Variables
        private Animator animator;

        // animator parameter
        protected int isSitHash = Animator.StringToHash("IsSit");
        #endregion

        // 오버라이드
        #region Override
        // 초기화 메서드 - 생성 후 1회 실행
        public override void OnInitialized()
        {
            // 참조
            animator = context.GetComponent<Animator>();
        }

        // 상태 전환 시 State Enter에 1회 실행
        public override void OnEnter()
        {
            animator.SetBool(isSitHash, true);
        }

        // 상태 전환 시 State Exit에 1회 실행
        public override void OnExit()
        {
            animator.SetBool(isSitHash, false);
        }

        public override void Update(float deltaTime)
        {
            
        }
        #endregion
    }
}